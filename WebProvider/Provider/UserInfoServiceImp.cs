using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Dao;
using Webs.Model;

namespace Webs.Provider
{
   public class UserInfoProvider
    {
       private static UserInfoProvider _instance = new UserInfoProvider();

       public static UserInfoProvider Instance
        {
            get { return _instance; }        
        }
        public OperationResult<UserInfo> GetUser(int userId)
        {
            var result = new OperationResult<UserInfo>();
            var user = WebUserDao.GetUserById(userId);
            if (user != null)
            {
                result.Code = OperationResultCodeType.Success;
                result.Data = user;
                result.Result = true;
            }
            else
            {
                result.Message = "无法获取用户信息";
            }
            return result;
        }
    }
}
