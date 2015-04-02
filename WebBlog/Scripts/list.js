/// <reference path="http://r.xieqj.cn/lib/jquery-2.1.3.js" />
var pageWrap = {
    channelId: 0,
    currentIndex: 1,
    pageSize: 5,
    detailUrlTpl: "",
    listTpl: "",
    initPage: function () {
        pageWrap.syncList();
        $("#more").click(pageWrap.syncList);
      
    },
    syncList: function () {
        var pageIndex = pageWrap.currentIndex;
        var tpl = pageWrap.listTpl;
        $.post(pageData.pagerUrl, { "pageSize": pageWrap.pageSize, "pageCurrentIndex": pageIndex, "channelId": pageWrap.channelId, "simpleSize": 328 }, function (data) {
            pageIndex++
            if ((data.List) && (data.List.length > 0)) {
                for (var i = 0; i < data.List.length; i++) {
                    tpl = tpl.replace("{$0}", pageData.detailUrlTpl + data.List[i].InfoId);
                    $("#pageList").append(tpl.replace("{$1}", data.List[i].InfoTitle).replace("{$2}", data.List[i].InfoContent));
                }
            } else {
                pageIndex--
                $(".more").hide();
            }
            pageWrap.currentIndex = pageIndex;
        }, "json");
    }
};
  
