using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webs.Model;
using Webs.Provider;
using Webs.ViewModel;

namespace Webs.WebProvider
{
    public class NewsController : Controller
    {
        private int _siteId = 2;
        //
        // GET: /Info/

        public ActionResult Index()
        {
            Dictionary<int, ChannelView> blockData = new Dictionary<int, ChannelView>();
            int channelCount = 0;
            var channels = ChannelProvider.Intance.GetShowIndexChannels(channelCount, _siteId);
            if (channels.Result)
            { channels.Data = new List<Model.Channel>(); }
            channels.Data.ForEach(a =>
            {
                var view = (ChannelView)a;
                view.ChannelContent = InfoProvider.Instance.GetListByChannelId(a.ChannelId).Data;
                blockData.Add(a.ChannelId, view);
            });

            int lableCount = 0;
            var labels = LableProvider.Instance.GetShowIndexLables(lableCount);
            if (labels.Result) labels.Data = new List<Model.Lable>();
            ViewData["channelsData"] = channels.Data;
            ViewData["labelsData"] = labels.Data;
            return View();
        }
        public ActionResult List(int channelId)
        {
            var channels = ChannelProvider.Intance.GetAllList(_siteId);
            if (channels.Result)
            { channels.Data = new List<Model.Channel>(); }
            int lableCount = 0;
            var labels = LableProvider.Instance.GetShowIndexLables(lableCount);
            if (labels.Result) labels.Data = new List<Model.Lable>();
            ViewData["channelsData"] = channels.Data;
            ViewData["labelsData"] = labels.Data;
            return View();
        }
        public ActionResult Detail(int id)
        {
            var channels = ChannelProvider.Intance.GetAllList(_siteId);
            if (channels.Result)
            { channels.Data = new List<Model.Channel>(); }
            int lableCount = 0;
            var labels = LableProvider.Instance.GetShowIndexLables(lableCount);
            if (labels.Result) labels.Data = new List<Model.Lable>();
            var info = InfoProvider.Instance.GetInfoById(id);
            ViewData["channelsData"] = channels.Data;
            ViewData["labelsData"] = labels.Data;
            return View(info);
        }
        public ActionResult About(int id)
        {
           
            var info = InfoProvider.Instance.GetInfoById(id);
            return View(info);
        }
        public ActionResult Contact(int id)        {
           
            var info = InfoProvider.Instance.GetInfoById(id);
            return View(info);
        }
    }
}
