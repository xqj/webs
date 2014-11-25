using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Webs.Model;
using Webs.Provider;

namespace Webs.WebProvider
{
    public class AdminController : Controller
    {
        [UserSecurity]
        public ActionResult ChannelList(int siteId)
        {
            var channels = ChannelProvider.Intance.GetAllList(siteId);
            if (channels.Result)
            { channels.Data = new List<Model.Channel>(); }
            return View(channels);
        }
        [UserSecurity]
        [HttpPost]
        public ActionResult GetChannels(int siteId)
        {
            var channels = ChannelProvider.Intance.GetAllList(siteId);
            if (channels.Result)
            { channels.Data = new List<Model.Channel>(); }
            return Json(channels);
        }
        [UserSecurity]
        [HttpPost]
        public ActionResult InfoPager(int pageSize, int pageCurrentIndex, int channelId)
        {
            List<Info> datas = new List<Info>();
            var infos = InfoProvider.Instance.GetPager(pageSize, pageCurrentIndex, channelId);
            return Json(datas);
        }
           [UserSecurity]
        public ActionResult Detail(int id)
        {          
            var info = InfoProvider.Instance.GetInfoById(id);         
            return View(info);
        }
           [UserSecurity]
           [HttpPost]
           public ActionResult InfoEdit(int infoId, int channelId,int ShowSort,string infoTitle,string infoContent,bool Enable,string TitleImg=null)
           {
               var user = CurrentUser.GetSafeCurrentUser();
               OperationMsg msg = InfoProvider.Instance.Edit(user.UserId,infoId, channelId, ShowSort, infoTitle, infoContent, Enable, TitleImg);
               return Json(msg);
           }
    }
}
