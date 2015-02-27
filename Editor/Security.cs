using System;
using System.Web;

namespace Editor
{
	public class Security
	{
		public static void SecurityUser ()
		{
			HttpCookie cookie = HttpContext.Current.Request.Cookies["sc"];
			bool isLogin = false;
				if (cookie != null)
			{
				isLogin = Login(HttpUtility.UrlDecode(cookie.Value));
			}
			if (!isLogin)
				HttpContext.Current.Response.Redirect("~/404.html", true);
		}
		public static bool Login(string cookieVal)
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
	}
}

