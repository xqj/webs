using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Model;

namespace Webs.Dao
{
   internal class WebUserDao
    {
       internal static UserInfo Login(string loginName, string pwd)
        {
            UserInfo data = null;
            StringBuilder sqlCmd = new StringBuilder("select * from WebUser where LoginName='");
            sqlCmd.Append(loginName);
            sqlCmd.Append("' and Pwd='");
            sqlCmd.Append(pwd);
            sqlCmd.Append("' and IsDelete=0 and Enable=1");
              using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
            {
                if (dr.Read())
                {
                    data = new UserInfo() {
                        Email = dr["Email"].ToString(),
                        LoginName = dr["LoginName"].ToString(),
                        Mobile = dr["Mobile"].ToString(),
                        QQ = dr["QQ"].ToString(),
                        UserId = dr.GetInt32("UserId"),
                        UserName = dr["UserName"].ToString() 
                    };
                }
            }
              return data;
        }

       internal static UserInfo GetUserById(int userId)
       {
           UserInfo data = null;
           StringBuilder sqlCmd = new StringBuilder("select * from WebUser where UserId=");
           sqlCmd.Append(userId.ToString());
           sqlCmd.Append(" and IsDelete=0 and Enable=1");
           using (var dr = MysqlHelper.ExcuteReader(sqlCmd.ToString()))
           {
               if (dr.Read())
               {
                   data = new UserInfo()
                   {
                       ModifyTime = dr.GetDateTime("ModifyTime"),
                       CreateTime = dr.GetDateTime("CreateTime"),
                       Enable = dr.GetBoolean("Enable"),
                       ModifyBy = dr.GetInt32("ModifyBy"),
                       CreateBy = dr.GetInt32("CreateBy"),
                       Email = dr["Email"].ToString(),
                       LoginName = dr["LoginName"].ToString(),
                       Mobile = dr["Mobile"].ToString(),
                       QQ = dr["QQ"].ToString(),
                       UserId = dr.GetInt32("UserId"),
                       UserName = dr["UserName"].ToString(),
                       Pwd = dr["Pwd"].ToString()
                   };
               }
           }
           return data;
       }
    }
}
