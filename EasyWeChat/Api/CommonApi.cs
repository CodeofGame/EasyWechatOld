using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyWeChat.Api
{
    public static class CommonApi
    {
        public static readonly string ApiPrefix="https://qyapi.weixin.qq.com/cgi-bin";

        public static string GetAccessToken(string corpid,string corpsecret)
        {
            string url = string.Format(ApiPrefix + "/gettoken?corpid={0}&corpsecret={1}",corpid,corpsecret);
            return url;
        }
    }
}
