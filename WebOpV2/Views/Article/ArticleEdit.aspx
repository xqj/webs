<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Page.Master" AutoEventWireup="true" CodeBehind="ArticleEdit.aspx.cs" Inherits="WebOpV2.Views.Article.ArticleEdit" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CssContent" runat="server">
    <link href="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap-wysihtml5/bootstrap-wysihtml5.css" rel="stylesheet" type="text/css" />
    <link href="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap-markdown/css/bootstrap-markdown.min.css" rel="stylesheet" type="text/css" />
    <link href="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap-summernote/summernote.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TopMenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MenuContent" runat="server">
    <li class="nav-item start active open">
        <a href="javascript:;" class="nav-link nav-toggle">
            <i class="icon-home"></i>
            <span class="title">博客管理</span>
            <span class="selected"></span>
            <span class="arrow open"></span>
        </a>
        <ul class="sub-menu">
            <li class="nav-item start active open">
                <a href="ArticleList.aspx" class="nav-link ">
                    <i class="icon-bar-chart"></i>
                    <span class="title">文章管理</span>
                    <span class="selected"></span>
                </a>
            </li>

        </ul>
    </li>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-content">
        <h1 class="page-title">Markdown &amp; 编辑器                          
            <small>编辑文章</small>
        </h1>
        <div class="row">
            <div class="col-md-12">
                <div class="portlet light form-fit bordered">
                   
                    <div class="portlet-body form">
                        <form class="form-horizontal form-bordered" method="post">
                            <div class="form-body">
                                <div class="form-group">
                                    <label class="control-label col-md-2"></label>
                                    <div class="col-md-10">
                                        <div class="md-editor">
                                            <div class="md-header btn-toolbar">
                                                <div class="btn-group">
                                                    <button class="btn-default btn-sm btn" type="button" title="Bold" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdBold" data-hotkey="Ctrl+B"><span class="glyphicon glyphicon-bold"></span></button>
                                                    <button class="btn-default btn-sm btn" type="button" title="Italic" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdItalic" data-hotkey="Ctrl+I"><span class="glyphicon glyphicon-italic"></span></button>
                                                    <button class="btn-default btn-sm btn" type="button" title="Heading" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdHeading" data-hotkey="Ctrl+H"><span class="glyphicon glyphicon-header"></span></button>
                                                </div>
                                                <div class="btn-group">
                                                    <button class="btn-default btn-sm btn" type="button" title="URL/Link" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdUrl" data-hotkey="Ctrl+L"><span class="glyphicon glyphicon-link"></span></button>
                                                    <button class="btn-default btn-sm btn" type="button" title="Image" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdImage" data-hotkey="Ctrl+G"><span class="glyphicon glyphicon-picture"></span></button>
                                                </div>
                                                <div class="btn-group">
                                                    <button class="btn-default btn-sm btn" type="button" title="Unordered List" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdList" data-hotkey="Ctrl+U"><span class="glyphicon glyphicon-list"></span></button>
                                                    <button class="btn-default btn-sm btn" type="button" title="Ordered List" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdListO" data-hotkey="Ctrl+O"><span class="glyphicon glyphicon-th-list"></span></button>
                                                    <button class="btn-default btn-sm btn" type="button" title="Code" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdCode" data-hotkey="Ctrl+K"><span class="glyphicon glyphicon-asterisk"></span></button>
                                                    <button class="btn-default btn-sm btn" type="button" title="Quote" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdQuote" data-hotkey="Ctrl+Q"><span class="glyphicon glyphicon-comment"></span></button>
                                                </div>
                                                <div class="btn-group">
                                                    <button class="btn-sm btn btn-primary" type="button" title="Preview" tabindex="-1" data-provider="bootstrap-markdown" data-handler="bootstrap-markdown-cmdPreview" data-hotkey="Ctrl+P" data-toggle="button"><span class="glyphicon glyphicon-search"></span>Preview</button>
                                                </div>
                                                <div class="md-controls"><a class="md-control md-control-fullscreen" href="#"><span class="glyphicon glyphicon-fullscreen"></span></a></div>
                                            </div>
                                            <textarea name="content" data-provide="markdown" rows="10" class="md-input" style="resize: none;"></textarea><div class="md-fullscreen-controls"><a href="#" class="exit-fullscreen" title="Exit fullscreen"><span class="glyphicon glyphicon-fullscreen"></span></a></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="form-actions">
                                <div class="row">
                                    <div class="col-md-offset-2 col-md-10">
                                        <button type="submit" class="btn dark">
                                            <i class="fa fa-check"></i>提交</button>
                                        <button type="button" class="btn default">取消</button>
                                    </div>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
