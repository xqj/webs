using System.Web.Mvc;

namespace Webs.WebProvider
{
    public class meAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "me";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "me_default",
                "me/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
