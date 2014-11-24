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
    public class InfoController : Controller
    {
        private int _siteId = 1;
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
            ViewData["channelsData"] = channels;
            ViewData["labelsData"] = labels;
            return View();
        }
        public ActionResult List()
        {

            var channels = ChannelProvider.Intance.GetAllList(_siteId);
            if (channels.Result)
            { channels.Data = new List<Model.Channel>(); }
            int lableCount = 0;
            var labels = LableProvider.Instance.GetShowIndexLables(lableCount);
            if (labels == null) labels.Data = new List<Model.Lable>();
            ViewData["channelsData"] = channels;
            ViewData["labelsData"] = labels;
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
    }
}
