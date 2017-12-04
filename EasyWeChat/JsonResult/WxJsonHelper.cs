using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyWeChat.HttpHelper;
using EasyWeChat.Api;
namespace EasyWeChat.JsonResult
{
    public static class WxJsonHelper
    {
        public static AccessTokenJsonResult GetAccessToken(string corpid, string corpsecret)
        {
            return ApiHelper.Get<AccessTokenJsonResult>(CommonApi.GetAccessToken(corpid, corpsecret));
        }
    }
}
