using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Webs.Provider;


namespace Webs.WebProvider
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class UserSecurityAttribute : ActionFilterAttribute, IAuthorizationFilter
    {      

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[DefineTable.LoginCookieName];
            bool isLogin = false;
            if (cookie != null)
            {
                isLogin = SecurityProvider.Instance.isLogin(cookie.Value);
            }
            if (!isLogin)
                HttpContext.Current.Response.Redirect("~/Error.aspx", true);
        }
    }
}
