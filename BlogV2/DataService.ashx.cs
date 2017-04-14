using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webs.WebProvider;

namespace BlogV2
{
    /// <summary>
    /// DataService 的摘要说明
    /// </summary>
    public class DataService : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int pageIndex = int.Parse(context.Request["pageIndex"]);
            context.Response.ContentType = "application/Json";
            var service = new PagerController();
            var data= service.List(10, pageIndex, 1, 0);
            context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(data.List));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}