﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebOpV2.Views.Shared.WebForm1" %>

<!DOCTYPE html>
<!--[if IE 8]> <html lang="en" class="ie8 no-js"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9 no-js"> <![endif]-->
<!--[if !IE]><!-->
<html lang="en">
    <!--<![endif]-->
    <!-- BEGIN HEAD -->

    <head>
        <meta charset="utf-8" />
        <title>信息管理后台</title>
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta content="width=device-width, initial-scale=1" name="viewport" />       
        <!-- BEGIN GLOBAL MANDATORY STYLES -->
        <link href="http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700&subset=all" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/simple-line-icons/simple-line-icons.min.css" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css" rel="stylesheet" type="text/css" />
        <!-- END GLOBAL MANDATORY STYLES -->
        <!-- BEGIN PAGE LEVEL PLUGINS -->
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.css" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/morris/morris.css" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/fullcalendar/fullcalendar.min.css" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/jqvmap.css" rel="stylesheet" type="text/css" />
        <!-- END PAGE LEVEL PLUGINS -->
        <!-- BEGIN THEME GLOBAL STYLES -->
        <link href="http://r.xieqj.cn/opv2/assets/global/css/components.min.css" rel="stylesheet" id="style_components" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/global/css/plugins.min.css" rel="stylesheet" type="text/css" />
        <!-- END THEME GLOBAL STYLES -->
        <!-- BEGIN THEME LAYOUT STYLES -->
        <link href="http://r.xieqj.cn/opv2/assets/layouts/layout/css/layout.min.css" rel="stylesheet" type="text/css" />
        <link href="http://r.xieqj.cn/opv2/assets/layouts/layout/css/themes/darkblue.min.css" rel="stylesheet" type="text/css" id="style_color" />
        <link href="http://r.xieqj.cn/opv2/assets/layouts/layout/css/custom.min.css" rel="stylesheet" type="text/css" />
        <!-- END THEME LAYOUT STYLES -->
        <link rel="shortcut icon" href="favicon.ico" /> </head>
    <!-- END HEAD -->

    <body class="page-header-fixed page-sidebar-closed-hide-logo page-content-white">
        <div class="page-wrapper">
            <!-- BEGIN HEADER -->
            <div class="page-header navbar navbar-fixed-top">
                <!-- BEGIN HEADER INNER -->
                <div class="page-header-inner ">
                    <!-- BEGIN LOGO -->
                    <div class="page-logo">
                        <a href="index.html">
                            <img src="http://r.xieqj.cn/opv2/assets/layouts/layout/img/logo.png" alt="logo" class="logo-default" /> </a>
                        <div class="menu-toggler sidebar-toggler">
                            <span></span>
                        </div>
                    </div>
                    <!-- END LOGO -->
                    <!-- BEGIN RESPONSIVE MENU TOGGLER -->
                    <a href="javascript:;" class="menu-toggler responsive-toggler" data-toggle="collapse" data-target=".navbar-collapse">
                        <span></span>
                    </a>
                    <!-- END RESPONSIVE MENU TOGGLER -->
                    <!-- BEGIN TOP NAVIGATION MENU -->
                    <div class="top-menu">
                        <ul class="nav navbar-nav pull-right">
                            <!-- BEGIN NOTIFICATION DROPDOWN -->
                           
                          
                           
                            <!-- BEGIN USER LOGIN DROPDOWN -->
                            <!-- DOC: Apply "dropdown-dark" class after below "dropdown-extended" to change the dropdown styte -->
                            <li class="dropdown dropdown-user">
                                <a href="javascript:;" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown" data-close-others="true">
                                    <img alt="" class="img-circle" src="http://r.xieqj.cn/opv2/assets/layouts/layout/img/avatar3_small.jpg" />
                                    <span class="username username-hide-on-mobile"> 用户名 </span>                                   
                                </a>
                              
                            </li>
                            <!-- END USER LOGIN DROPDOWN -->
                            <!-- BEGIN QUICK SIDEBAR TOGGLER -->
                            <!-- DOC: Apply "dropdown-dark" class after below "dropdown-extended" to change the dropdown styte -->
                            <li class="dropdown dropdown-quick-sidebar-toggler">
                                <a href="Logout.aspx" class="dropdown-toggle">
                                   <i class="icon-logout"></i>
                                </a>
                            </li>
                            <!-- END QUICK SIDEBAR TOGGLER -->
                        </ul>
                    </div>
                    <!-- END TOP NAVIGATION MENU -->
                </div>
                <!-- END HEADER INNER -->
            </div>
            <!-- END HEADER -->
            <!-- BEGIN HEADER & CONTENT DIVIDER -->
            <div class="clearfix"> </div>
            <!-- END HEADER & CONTENT DIVIDER -->
            <!-- BEGIN CONTAINER -->
            <div class="page-container">
                <!-- BEGIN SIDEBAR -->
                <div class="page-sidebar-wrapper">
                    <!-- BEGIN SIDEBAR -->
                    <!-- DOC: Set data-auto-scroll="false" to disable the sidebar from auto scrolling/focusing -->
                    <!-- DOC: Change data-auto-speed="200" to adjust the sub menu slide up/down speed -->
                    <div class="page-sidebar navbar-collapse collapse">
                        <!-- BEGIN SIDEBAR MENU -->
                        <!-- DOC: Apply "page-sidebar-menu-light" class right after "page-sidebar-menu" to enable light sidebar menu style(without borders) -->
                        <!-- DOC: Apply "page-sidebar-menu-hover-submenu" class right after "page-sidebar-menu" to enable hoverable(hover vs accordion) sub menu mode -->
                        <!-- DOC: Apply "page-sidebar-menu-closed" class right after "page-sidebar-menu" to collapse("page-sidebar-closed" class must be applied to the body element) the sidebar sub menu mode -->
                        <!-- DOC: Set data-auto-scroll="false" to disable the sidebar from auto scrolling/focusing -->
                        <!-- DOC: Set data-keep-expand="true" to keep the submenues expanded -->
                        <!-- DOC: Set data-auto-speed="200" to adjust the sub menu slide up/down speed -->
                        <ul class="page-sidebar-menu  page-header-fixed " data-keep-expanded="false" data-auto-scroll="true" data-slide-speed="200" style="padding-top: 20px">
                            <!-- DOC: To remove the sidebar toggler from the sidebar you just need to completely remove the below "sidebar-toggler-wrapper" LI element -->
                            <!-- BEGIN SIDEBAR TOGGLER BUTTON -->
                            <li class="sidebar-toggler-wrapper hide">
                                <div class="sidebar-toggler">
                                    <span></span>
                                </div>
                            </li>
                            <!-- END SIDEBAR TOGGLER BUTTON -->
                          
                            <li class="nav-item start active open">
                                <a href="javascript:;" class="nav-link nav-toggle">
                                    <i class="icon-home"></i>
                                    <span class="title">Dashboard</span>
                                    <span class="selected"></span>
                                    <span class="arrow open"></span>
                                </a>
                                <ul class="sub-menu">
                                    <li class="nav-item start active open">
                                        <a href="index.html" class="nav-link ">
                                            <i class="icon-bar-chart"></i>
                                            <span class="title">Dashboard 1</span>
                                            <span class="selected"></span>
                                        </a>
                                    </li>
                                   
                                </ul>
                            </li>
                           
                        </ul>
                        <!-- END SIDEBAR MENU -->
                        <!-- END SIDEBAR MENU -->
                    </div>
                    <!-- END SIDEBAR -->
                </div>
                <!-- END SIDEBAR -->
                <!-- BEGIN CONTENT -->
                <div class="page-content-wrapper">
                    <!-- BEGIN CONTENT BODY -->
                    <div class="page-content">
                        <!-- BEGIN PAGE HEADER-->
                      
                      
                        <!-- BEGIN PAGE TITLE-->
                        <h1 class="page-title">主标题
                            <small>次标题</small>
                        </h1>
                        <!-- END PAGE TITLE-->
                        <!-- END PAGE HEADER-->
                        <!-- BEGIN DASHBOARD STATS 1-->
                        <div class="row">
                          
                        </div>
                        <div class="clearfix"></div>
                        <!-- END DASHBOARD STATS 1-->
                       
                    </div>
                    <!-- END CONTENT BODY -->
                </div>
                <!-- END CONTENT -->
                
            </div>
            <!-- END CONTAINER -->
            <!-- BEGIN FOOTER -->
            <div class="page-footer">
                <div class="page-footer-inner"> 2016 &copy; Metronic Theme By
                    <a target="_blank" href="http://keenthemes.com">Keenthemes</a> &nbsp;|&nbsp;
                    <a href="http://themeforest.net/item/metronic-responsive-admin-dashboard-template/4021469?ref=keenthemes" title="Purchase Metronic just for 27$ and get lifetime updates for free" target="_blank">Purchase Metronic!</a>
                </div>
                <div class="scroll-to-top">
                    <i class="icon-arrow-up"></i>
                </div>
            </div>
            <!-- END FOOTER -->
        </div>
       
        <!--[if lt IE 9]>
<script src="http://r.xieqj.cn/opv2/assets/global/plugins/respond.min.js"></script>
<script src="http://r.xieqj.cn/opv2/assets/global/plugins/excanvas.min.js"></script> 
<script src="http://r.xieqj.cn/opv2/assets/global/plugins/ie8.fix.min.js"></script> 
<![endif]-->
        <!-- BEGIN CORE PLUGINS -->
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jquery.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/js.cookie.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jquery.blockui.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js" type="text/javascript"></script>
        <!-- END CORE PLUGINS -->
        <!-- BEGIN PAGE LEVEL PLUGINS -->
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/moment.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/morris/morris.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/morris/raphael-min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/counterup/jquery.waypoints.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/counterup/jquery.counterup.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amcharts/amcharts.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amcharts/serial.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amcharts/pie.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amcharts/radar.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amcharts/themes/light.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amcharts/themes/patterns.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amcharts/themes/chalk.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/ammap/ammap.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/ammap/maps/js/worldLow.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/amcharts/amstockcharts/amstock.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/fullcalendar/fullcalendar.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/horizontal-timeline/horizontal-timeline.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/flot/jquery.flot.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/flot/jquery.flot.resize.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/flot/jquery.flot.categories.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jquery.sparkline.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/jquery.vmap.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.russia.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.world.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.europe.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.germany.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.usa.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js" type="text/javascript"></script>
        <!-- END PAGE LEVEL PLUGINS -->
        <!-- BEGIN THEME GLOBAL SCRIPTS -->
        <script src="http://r.xieqj.cn/opv2/assets/global/scripts/app.min.js" type="text/javascript"></script>
        <!-- END THEME GLOBAL SCRIPTS -->
        <!-- BEGIN PAGE LEVEL SCRIPTS -->
        <script src="http://r.xieqj.cn/opv2/assets/pages/scripts/dashboard.min.js" type="text/javascript"></script>
        <!-- END PAGE LEVEL SCRIPTS -->
        <!-- BEGIN THEME LAYOUT SCRIPTS -->
        <script src="http://r.xieqj.cn/opv2/assets/layouts/layout/scripts/layout.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/layouts/layout/scripts/demo.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/layouts/global/scripts/quick-sidebar.min.js" type="text/javascript"></script>
        <script src="http://r.xieqj.cn/opv2/assets/layouts/global/scripts/quick-nav.min.js" type="text/javascript"></script>
        <!-- END THEME LAYOUT SCRIPTS -->
    </body>

</html>