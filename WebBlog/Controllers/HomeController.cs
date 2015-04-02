using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webs.ViewModel;
using Webs.Provider;
using Webs.Model;

namespace Webs.WebProvider
{
    public class HomeController : Controller
    {     
		public ActionResult Index()
		{           
		
			return View();
		}
		public ActionResult list(int i=1)
        {           
			ViewData ["id"] = i;
            return View();
        }
        [HttpPost]
		public ActionResult InfoPager(int pageSize,int pageCurrentIndex,int channelId,int simpleSize)
        {
            var infos = InfoProvider.Instance.GetPager(pageSize, pageCurrentIndex, channelId);
			if (infos.List != null) {
				infos.List.ForEach (a => {
					a.InfoContent=(a.InfoContent.Length>simpleSize)?(a.InfoContent.Substring(0,(simpleSize-4))+"..."):a.InfoContent;
				});
			}
			return Json(infos);
        }
		public ActionResult Detail(int id)
        {
              var info = InfoProvider.Instance.GetInfoById(id);
			if (info.Result) {
				ViewData ["title"] = info.Data.InfoTitle;
				ViewData ["content"] = info.Data.InfoContent;
			}
            return View();
        }


    }
}
