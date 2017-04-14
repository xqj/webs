<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="BlogV2.List" %>

<!doctype html>
<html class="no-js" lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>我的技术博客</title>
    <link rel="stylesheet" href="http://r.xieqj.cn/blogv2/foundation.min.css">
    <link href="http://r.xieqj.cn/blogv2/foundation-icons.css" rel='stylesheet' type='text/css'>
</head>
<body>
    <div class="top-bar">
        <div class="top-bar-left">
            <ul class="menu">
                <li class="menu-text">博客</li>
                <li><a href="#">One</a></li>

            </ul>
        </div>
    </div>

    <div class="callout large primary">
        <div class="row column text-center">
            <h1>我的技术博客</h1>
            <h2 class="subheader">记录技术生涯的点点滴滴</h2>
        </div>
    </div>

    <div class="row medium-8 large-7 columns">
        <div class="blog-post">
            <h3>Awesome blog post title <small>3/6/2016</small></h3>
            <p>Praesent id metus massa, ut blandit odio. Proin quis tortor orci. Etiam at risus et justo dignissim congue. Donec congue lacinia dui, a porttitor lectus condimentum laoreet. Nunc eu ullamcorper orci. Quisque eget odio ac lectus vestibulum faucibus eget in metus. In pellentesque faucibus vestibulum. Nulla at nulla justo, eget luctus.</p>
            <div class="callout">
                <ul class="menu simple">
                    <li><a href="#">Author: Mike Mikers</a></li>
                    <li><a href="#">Comments: 3</a></li>
                </ul>
            </div>
        </div>
        <div class="blog-post">
            <h3>Awesome blog post title <small>3/6/2016</small></h3>
            <p>Praesent id metus massa, ut blandit odio. Proin quis tortor orci. Etiam at risus et justo dignissim congue. Donec congue lacinia dui, a porttitor lectus condimentum laoreet. Nunc eu ullamcorper orci. Quisque eget odio ac lectus vestibulum faucibus eget in metus. In pellentesque faucibus vestibulum. Nulla at nulla justo, eget luctus.</p>
            <div class="callout">
                <ul class="menu simple">
                    <li><a href="#">Author: Mike Mikers</a></li>
                    <li><a href="#">Comments: 3</a></li>
                </ul>
            </div>
        </div>
        <div id="btnWrap" class="blog-post">

            <a id="moreBtn" href="javascript:void(0);">更多</a>

        </div>
    </div>
    <script src="https://code.jquery.com/jquery-2.1.4.min.js"></script>
    <script src="http://r.xieqj.cn/blogv2/foundation.js"></script>
    <script>
        $(document).foundation();
        $(function () {
            var pageIndex = 1;
            $("#moreBtn").on("click", function () {
                pageIndex = pageIndex + 1;
                $.post("DataService.ashx", { pageIndex: pageIndex }, function (data) {
                    if (data) {
                        for (var i = 0; i < data.length;i++)
                        $("#btnWrap").insertBefore();
                    }
                });
            });
        });
    </script>

</body>
</html>

