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
        private static Dictionary<string, AccessTokenBag> AccessTokenCollection = new Dictionary<string, AccessTokenBag>(StringComparer.OrdinalIgnoreCase);

        public static string TryGetToken(string CorpID,string Secret,bool getNewToken=false)
        {
            if(!CheckRegistered(CorpID) || getNewToken)
            {
                Register(CorpID,Secret);
            }
            return GetRo
        }

        /// <summary>
        /// 检查企业Id是否注册
        /// </summary>
        /// <param name="CorpID">企业iD</param>
        /// <returns></returns>
        private static bool CheckRegistered(string CorpID)
        {
            return AccessTokenCollection.ContainsKey(CorpID);
        }

        private static Register(string CorpID,string Secret)
        {
            AccessTokenBag bag=new AccessTokenBag();
            bag.CorpID=CorpID;
            bag.Secret=Secret;
            bag.ExpireTime=DateTime.MinValue;
            bag.AccessTokenJsonResult= new AccessTokenJsonResult();
            AccessTokenCollection[CorpID]=bag;
        }

        private static GetAccessTokenResult(string corpID,bool getNewToken=false)
        {
            if(!AccessTokenCollection.ContainsKey(corpID))
            {
                throw new Exception(string.Format("企业号{0}尚未在代码里注册！",corpID));
            }
            AccessTokenBag accessTokenBag=AccessTokenCollection[corpID];

            //用户选择重新获取或者token已经过期
            if(getNewToken || DateTime.Now > accessTokenBag.ExpireTime)
            {
                
            }

        }



    }
}
