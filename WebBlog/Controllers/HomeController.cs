﻿using System;
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
        [HttpPost]
        public ActionResult InfoPager(int pageSize,int pageCurrentIndex,int channelId)
        {
            var infos = InfoProvider.Instance.GetPager(pageSize, pageCurrentIndex, channelId);
			return Json(infos);
        }
        public ActionResult Detail(int id)
        {
              var info = InfoProvider.Instance.GetInfoById(id);
           
            return View(info);
        }
    }
}
