using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyWeChat.JsonResult;

namespace EasyWeChat.Container
{
    public class AccessTokenBag
    {
        /// <summary>
        /// 企业Id
        /// </summary>
        public string CorpID { get; set; }
        /// <summary>
        /// 秘钥
        /// </summary>
        public string Secret { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpireTime { get; set; }

        public AccessTokenJsonResult AccessTokenJsonResult { get; set; }
    }
}
