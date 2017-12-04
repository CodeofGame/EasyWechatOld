using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
namespace EasyWeChat.HttpHelper
{
    public static class HttpUtility
    {
        /// <summary>
        /// 发送get请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string HttpGet(string url, Encoding encoding = null)
        {
            WebClient wc = new WebClient();
            wc.Encoding = encoding ?? Encoding.UTF8;
            return wc.DownloadString(url);
        }

        /// <summary>
        /// 发送Post请求
        /// </summary>
        public static string HttpPost(string url, Stream postStream, Encoding encoding = null)
        {
            HttpWebRequest request =(HttpWebRequest) WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postStream != null ? postStream.Length : 0;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.KeepAlive = true;
            request.UserAgent = "ozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
            Stream requestStream = request.GetRequestStream();
            if (postStream != null)
            {
                byte[] buffer = new byte[1024];
                int byteRead = 0;
                while ((byteRead = postStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    requestStream.Write(buffer, 0, byteRead);
                }
                //防止内存泄漏
                postStream.Close();
            }

            HttpWebResponse response =(HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream,encoding??Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
