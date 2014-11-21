using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Dao;
using Webs.Model;

namespace Webs.Provider
{
   public class SecurityServiceImp
    {
        private static SecurityServiceImp _instance = new SecurityServiceImp();

        public static SecurityServiceImp Instance
        {
            get { return SecurityServiceImp._instance; }         
        }
        public SecurityServiceImp()
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
    }
}
