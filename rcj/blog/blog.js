var page=window.pageData;
var pageAction={
   pageSize:4,
   pageCurrentIndex:1,
   initLinkAction:function(){
   $(".tc").click(pageAction.changeChannel);
   $(".bigmore").click(pageAction.initList);
   },
	initList:function(){
	$.post(page.infoUrl, { "pageSize": pageAction.pageSize, "pageCurrentIndex": pageAction.pageCurrentIndex, "channelId": pageData.channelId },
     function (data) {
            pageIndex=pageAction.pageCurrentIndex;
            pageIndex++
            if ((data.List) && (data.List.length > 0)) {
                for (var i = 0; i < data.List.length; i++) {
                var html='<div class="rightListdiv">';
                html=html+' <h1><a href="Home/Detail/'+data.List[i].InfoId+'" class="rightListdiva" target="_blank">'+((data.List[i].InfoTitle.length>16)?data.List[i].InfoTitle.substring(0,16):data.List[i].InfoTitle)+'</a></h1>';
                if(data.List[i].IsTitleImg)
                    html=html+' <div class="wrapImg"><img src="'+data.List[i].TitleImg+'" class="listimg" /></div>';
                 html=html+'&nbsp&nbsp&nbsp'+((data.List[i].InfoContent.length>137)?data.List[i].InfoContent.substring(0,137):data.List[i].InfoContent)+'......【<a href="Home/Detail/'+data.List[i].InfoId+'" class="more" target="_blank">更多</a>】</div>';
                $("#infolist").append(html);
                }
            } else {
                pageIndex--               
            }
            pageAction.pageCurrentIndex = pageIndex;
        }, "json");
	},
    changeChannel:function(id){
        page.channelId=id;
        pageAction.initList();
    }
}
    pageAction.initLinkAction();
    pageAction.initList();
