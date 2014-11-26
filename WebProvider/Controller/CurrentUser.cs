using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Webs.Model;
using Webs.Provider;

namespace Webs.WebProvider
{
   public class CurrentUser
    {
       public static OperationResult<UserInfo> GetCurrentUser()
       {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[DefineTable.LoginCookieName];
            if (cookie != null)
                return SecurityProvider.Instance.GetCurrentUser(HttpUtility.UrlDecode(cookie.Value));
            return new OperationResult<UserInfo>();
       }
       public static UserInfo GetSafeCurrentUser()
       {
           HttpCookie cookie = HttpContext.Current.Request.Cookies[DefineTable.LoginCookieName];
           if (cookie != null)
           {
               var info = SecurityProvider.Instance.GetCurrentUser(HttpUtility.UrlDecode(cookie.Value));
               if (info.Result)
                   return info.Data;
           }
           return new UserInfo();
       }

       internal static void SetCookie(UserInfo userInfo)
       {
           HttpCookie cookie = new HttpCookie(DefineTable.LoginCookieName);
           cookie.Expires = DateTime.Now.AddDays(1);
           cookie.HttpOnly = true;
           cookie.Value =HttpUtility.UrlEncode(userInfo.UserId.ToString() + "&" + System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(userInfo.UserId.ToString(), "MD5"));
           HttpContext.Current.Response.SetCookie(cookie);
       }
    }
}
