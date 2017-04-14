<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Page.Master" AutoEventWireup="true" CodeBehind="ArticleList.aspx.cs" Inherits="WebOpV2.Views.Article.ArticleList" %>
  <asp:Content ID="Content0" ContentPlaceHolderID="CssContent" runat="server">
 
  </asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="TopMenuContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContent" runat="server">
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
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <div class="col-md-6">
        <!-- BEGIN SAMPLE TABLE PORTLET-->
        <div class="portlet">
            <div class="portlet-title">
                <div class="caption">
                    <i class="fa fa-bell-o"></i>文章列表
                </div>
              <%--  <div class="tools">                   
                    <a href="javascript:;" class="remove"></a>
                </div>--%>
            </div>
            <div class="portlet-body">
                <div class="table-scrollable">
                    <table class="table table-striped table-bordered table-advance table-hover">
                        <thead>
                            <tr>
                                 <th>
                                    ID </th>
                                <th>
                                    标题 </th>
                                <th class="hidden-xs">
                                    <i class="fa fa-user"></i>创建时间 </th>
                             
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                  <td class="highlight">
                                   1
                                </td>
                                <td class="highlight">
                                    <a href="javascript:;">RedBull </a>
                                </td>
                                <td class="hidden-xs">Mike Nilson </td>
                                 <td>
                                    <a href="javascript:;" class="btn btn-outline btn-circle btn-sm purple">
                                        <i class="fa fa-edit"></i>Edit </a>
                                    <a href="javascript:;" class="btn btn-outline btn-circle dark btn-sm black">
                                        <i class="fa fa-trash-o"></i>Delete </a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <!-- END SAMPLE TABLE PORTLET-->
    </div>
        </div>
</asp:Content>
