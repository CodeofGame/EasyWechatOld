using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyWeChat.HttpHelper;
using EasyWeChat.Api;
using EasyWeChat.JsonResult;
namespace EasyWeChat.Container
{
    /// <summary>
    /// accessToken自治类，过期自动刷新
    /// </summary>
    public class AccessTokenContainer
    {
        public static Dictionary<string, AccessTokenBag> AccessTokenCollection = new Dictionary<string, AccessTokenBag>(StringComparer.OrdinalIgnoreCase);

        public static string TryGetToken(string CorpID,string Secret,bool getNewToken=false)
        {
            string key=GetFinalKey(CorpID,Secret);
            if(!CheckRegistered(key) || getNewToken)
            {
                Register(CorpID,Secret);
            }
            return GetToken(CorpID, Secret);
        }

        /// <summary>
        /// 检查企业Id是否注册
        /// </summary>
        /// <param name="CorpID">企业iD</param>
        /// <returns></returns>
        private static bool CheckRegistered(string key)
        {
            return AccessTokenCollection.ContainsKey(key);
        }

        public static string GetToken(string corpId, string secret)
        { 
            string key=GetFinalKey(corpId,secret);
            return GetAccessTokenResult(key).access_token;
        }


        /// <summary>
        /// 注册企业号
        /// </summary>
        /// <param name="CorpID"></param>
        /// <param name="Secret"></param>
        private static void Register(string CorpID,string Secret)
        {
            string key=GetFinalKey(CorpID,Secret);
            AccessTokenBag bag=new AccessTokenBag();
            bag.CorpID=CorpID;
            bag.Secret=Secret;
            bag.ExpireTime=DateTime.MinValue;
            bag.AccessTokenJsonResult= new AccessTokenJsonResult();
            AccessTokenCollection[key]=bag;
        }

        private static AccessTokenJsonResult GetAccessTokenResult(string key, bool getNewToken = false)
        {
            if(!AccessTokenCollection.ContainsKey(key))
            {
                throw new Exception(string.Format("企业号{0}尚未在代码里注册！",key));
            }
            AccessTokenBag accessTokenBag=AccessTokenCollection[key];

            //用户选择重新获取或者token已经过期
            if(getNewToken || DateTime.Now > accessTokenBag.ExpireTime)
            {
                accessTokenBag.AccessTokenJsonResult=ApiHelper.Get<AccessTokenJsonResult>(CommonApi.GetAccessToken(accessTokenBag.CorpID,accessTokenBag.Secret));
                //考虑到网络延时提前20秒过期
                accessTokenBag.ExpireTime=DateTime.Now.AddSeconds( accessTokenBag.AccessTokenJsonResult.expires_in-20);
            }
            return accessTokenBag.AccessTokenJsonResult;
        }
        
        private static string GetFinalKey(string corpID,string secret) 
        {
            return string.Format("{0}@{1}",corpID,secret);
        }

        public static int Count
        {
            get
            {
                return AccessTokenCollection.Count();
            }
        }




    }
}
