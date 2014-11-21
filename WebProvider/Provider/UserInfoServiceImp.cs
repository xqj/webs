using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Dao;
using Webs.Model;

namespace Webs.WebProvider.Provider
{
   public class UserInfoServiceImp
    {
        private static UserInfoServiceImp _instance = new UserInfoServiceImp();

        public static UserInfoServiceImp Instance
        {
            get { return UserInfoServiceImp._instance; }        
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
