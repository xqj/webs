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
       
		public ActionResult Index(int i=1)
        {           
			ViewData ["id"] = i;
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
			if (info.Result) {
				ViewData ["title"] = info.Data.InfoTitle;
				ViewData ["content"] = info.Data.InfoContent;
			}
            return View();
        }
		public static string mobile()
		{
			String userAgent = Request.Headers ["User-Agent"];
			if (userAgent.IndexOf("Noki") > -1 || // Nokia phones and emulators     
				userAgent.IndexOf("Eric") > -1 || // Ericsson WAP phones and emulators     
				userAgent.IndexOf("WapI") > -1 || // Ericsson WapIDE 2.0     
				userAgent.IndexOf("MC21") > -1 || // Ericsson MC218     
				userAgent.IndexOf("AUR") > -1 || // Ericsson R320     
				userAgent.IndexOf("R380") > -1 || // Ericsson R380     
				userAgent.IndexOf("UP.B") > -1 || // UP.Browser     
				userAgent.IndexOf("WinW") > -1 || // WinWAP browser     
				userAgent.IndexOf("UPG1") > -1 || // UP.SDK 4.0     
				userAgent.IndexOf("upsi") > -1 || //another kind of UP.Browser     
				userAgent.IndexOf("QWAP") > -1 || // unknown QWAPPER browser     
				userAgent.IndexOf("Jigs") > -1 || // unknown JigSaw browser     
				userAgent.IndexOf("Java") > -1 || // unknown Java based browser     
				userAgent.IndexOf("Alca") > -1 || // unknown Alcatel-BE3 browser (UP based)    
				userAgent.IndexOf("MITS") > -1 || // unknown Mitsubishi browser     
				userAgent.IndexOf("MOT-") > -1 || // unknown browser (UP based)     
				userAgent.IndexOf("My S") > -1 ||//  unknown Ericsson devkit browser      
				userAgent.IndexOf("WAPJ") > -1 ||//Virtual WAPJAG www.wapjag.de     
				userAgent.IndexOf("fetc") > -1 ||//fetchpage.cgi Perl script from www.wapcab.de 
				userAgent.IndexOf("ALAV") > -1 || //yet another unknown UP based browser     
				userAgent.IndexOf("Wapa") > -1 || //another unknown browser (Web based 	"Wapalyzer")    
				userAgent.IndexOf("UCWEB") > -1 || //another unknown browser (Web based "Wapalyzer")    
				userAgent.IndexOf("BlackBerry") > -1 || //another unknown browser (Web based "Wapalyzer")                     
				userAgent.IndexOf("J2ME") > -1 || //another unknown browser (Web based 				"Wapalyzer")              
				userAgent.IndexOf("Oper") > -1 ||
				userAgent.IndexOf("Android") > -1 ||
				userAgent.IndexOf("mozilla") > -1)
			{
				return "m";
			}
			else
			{
				return "";
			}
		}
    }
}
