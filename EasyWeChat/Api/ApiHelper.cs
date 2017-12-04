using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyWeChat.HttpHelper;
using EasyWeChat.JsonResult;
using System.Web.Script.Serialization;
using System.IO;

namespace EasyWeChat.Api
{
    public static class ApiHelper
    {
        /// <summary>
        /// get请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">请求url</param>
        /// <returns></returns>
        public static T Get<T>(string url) where T:WxJsonResult
        {
            string returnText = HttpUtility.HttpGet(url);
            return GetJsonResult<T>(returnText);
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static T Post<T>(string url, object data) where T:WxJsonResult
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            var jsonString = js.Serialize(data);
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(jsonString);
                ms.Write(bytes, 0, bytes.Length);
                ms.Seek(0, SeekOrigin.Begin);
                string returnText = HttpUtility.HttpPost(url, ms);
                return GetJsonResult<T>(returnText);
            }
        }


        public static T GetJsonResult<T>(string returnText) where T:WxJsonResult
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            //有可能发生错误
            if (returnText.Contains("errcode"))
            {
                WxJsonResult wxJson = js.Deserialize<WxJsonResult>(returnText);
                if (wxJson.errcode != ReturnCode.请求成功)
                {
                    throw new Exception(string.Format("微信请求发生错误！错误代码{0},说明{1}!", (int)wxJson.errcode, wxJson.errmsg));
                }
            }
            return js.Deserialize<T>(returnText);
            
        }

    }
}
