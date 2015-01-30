var opList = {
    currentIndex:1,
    pageSize: 15,   
    moreAction: function () {
        var pageIndex = opList.currentIndex;
        var url = '<li class="list"><a href="###" onclick="opContent.initContent($2)">$1</a></li>';
        $.post(pageData.pagerUrl, { "pageSize": opList.pageSize, "pageCurrentIndex": pageIndex, "channelId": pageData.channelId }, function (data) {
            pageIndex++
            if ((data.List) && (data.List.length > 0)) {
                for (var i = 0; i < data.List.length; i++) {
                    $("#infolist").append(url.replace("$1", data.List[i].InfoTitle).replace("$2", data.List[i].InfoId));
                }
            } else {
                pageIndex--               
            }
            opList.currentIndex = pageIndex;
        }, "json");
    }
}
var opContent = {
    cid:0,
    initContent: function (id) {
        opContent.cid = id;
        $.post(pageData.detailUrl, { "id": id }, function (dataw) {
        if(dataw.Result){
        var data=dataw.Data;
            $("#InfoId").html(id);
            $("#ShowSort").val(data.ShowSort);
            $("#InfoTitle").val(data.InfoTitle);
            $("#TitleImg").val(data.TitleImg);
            if (data.Enable == 0) {
                $("#aEnable").attr("checked",false);
            }
            $("#JumpUrl").val(data.JumpUrl);
            UE.getEditor('editor').setContent(data.InfoContent);
            }
        }, "json");

    },
	create: function () {
        opContent.cid = 0;
            $("#InfoId").html("0");
            $("#ShowSort").val("");
            $("#InfoTitle").val("");
            $("#TitleImg").val("");           
                $("#aEnable").attr("checked",true);           
            $("#JumpUrl").val("");
            UE.getEditor('editor').setContent("");
    },
    save: function () {
        var ea=$("#aEnable").attr("checked");
        var content=UE.getEditor('editor').getContent();
        $.post(pageData.saveUrl, { "id": opContent.cid, "ShowSort": $("#ShowSort").val(), "InfoTitle": $("#InfoTitle").val(), "TitleImg": $("#TitleImg").val(), "JumpUrl": $("#JumpUrl").val(), "InfoContent": content, "Enable": ea }, function (data) {
            alert(data.Message);
        }, "json");
    },
    del: function () {
        $.post(pageData.delUrl, { "id": opContent.cid }, function (data) {
            if (data.ActionResult) {
                window.location = "" + pageData.channelId;
            }else
            {
                alert(data.Message);
            }
        }, "json");
    }
}
function bingEvent() {
    $("#save").click(opContent.save);
     $("#new").click(opContent.create);
    $("#del").click(opContent.del);
    $("#more").click(opList.moreAction);
}
var ue = UE.getEditor('editor');
bingEvent();
opList.moreAction();