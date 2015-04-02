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
			//操作手册
			var list1 = InfoProvider.Instance.GetTopListByChannelId (1, 6);
			ViewData ["list1"] = list1;
			//凝点系列
			var list2 = InfoProvider.Instance.GetTopListByChannelId (2, 4);
			ViewData ["list2"] = list2;
			//日积月累
			var list3 = InfoProvider.Instance.GetTopListByChannelId (4, 6);
			ViewData ["list3"] = list3;
			//他山石
			var list4 = InfoProvider.Instance.GetTopListByChannelId (3, 8);
			ViewData ["list4"] = list4;
			//项目
			var list5 = InfoProvider.Instance.GetTopListByChannelId (5, 4);
			ViewData ["list5"] = list5;
			return View();
		}
		public ActionResult list(int i=1)
        {           
			ViewData ["id"] = i;
			var channel = ChannelProvider.Intance.GetById (1, i);
			if (channel.Result) {
				ViewBag.Title = channel.Data.ChannelName;
			}
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
				ViewData ["CreateTime"] = info.Data.CreateTime.ToString ("yyyy年MM月dd");
			}
            return View();
        }


    }
}
