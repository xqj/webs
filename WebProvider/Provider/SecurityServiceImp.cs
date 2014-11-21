using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Dao;
using Webs.Model;

namespace Webs.Provider
{
   public class SecurityProvider
    {
       private static SecurityProvider _instance = new SecurityProvider();

        public static SecurityProvider Instance
        {
            get { return _instance; }         
        }
        public SecurityProvider()
        {

        }
        public bool isLogin(string cookieVal)
        {
            if (!string.IsNullOrEmpty(cookieVal)) {
                string[] strArr = cookieVal.Split('&');
                if (strArr.Length == 3)
                {
                    string key=DateTime.Now.ToString("yyyyMMdd");
                    string keyS = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(strArr[1], "MD5");
                    if ((keyS == strArr[2]) && (strArr[0] == key))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public OperationResult<UserInfo> Login(string loginName,string pwd)
        {
            var result = new OperationResult<UserInfo>();
            var user=WebUserDao.Login(loginName, pwd);
            if (user != null)
            {
                result.Code = OperationResultCodeType.Success;
                result.Data = user;
                result.Result = true;
            }
            else
            {
                result.Message = "用户名或密码错误";
            }
            return result;
        }
        public OperationResult<UserInfo> GetCurrentUser(string cookieVal)
        {
            if (!string.IsNullOrEmpty(cookieVal))
            {
                string[] strArr = cookieVal.Split('&');
                if (strArr.Length == 3)
                {
                    int userId =0;
                    int.TryParse(strArr[1],out userId);
                   return UserInfoProvider.Instance.GetUser(userId);
                }
            }
            return new OperationResult<UserInfo>() { 
            Message="无法获取当前用户信息"
            };
        }
    }
}
