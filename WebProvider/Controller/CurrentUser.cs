using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Webs.Model;
using Webs.Provider;

namespace Webs.WebProvider.Controller
{
   public class CurrentUser
    {
       public static OperationResult<UserInfo> GetCurrentUser()
       {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[DefineTable.LoginCookieName];
            if (cookie != null)
                return SecurityProvider.Instance.GetCurrentUser(cookie.Value);
            return new OperationResult<UserInfo>();
       }
       public static UserInfo GetSafeCurrentUser()
       {
           HttpCookie cookie = HttpContext.Current.Request.Cookies[DefineTable.LoginCookieName];
           if (cookie != null)
           {
               var info = SecurityProvider.Instance.GetCurrentUser(cookie.Value);
               if (info.Result)
                   return info.Data;
           }
           return new UserInfo();
       }
    }
}
