using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyWeChat.HttpHelper;
using System.Configuration;
using EasyWeChat.HttpHelper;
using EasyWeChat.Api;
using EasyWeChat.JsonResult;
namespace Test
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            try
            {
                string CorpID=ConfigurationManager.AppSettings["CorpID"].ToString();
                string c = ConfigurationManager.AppSettings["Secret"].ToString();
                var json= WxJsonHelper.GetAccessToken(CorpID, c);
                Console.WriteLine(json.access_token);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
