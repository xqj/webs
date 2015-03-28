<%@ Page Language="C#" Inherits="WebHi.Default" MasterPageFile="Common.master"%>
<asp:Content ID="pageHead" ContentPlaceHolderID="head" runat="server">
    <link href="http://r.xieqj.cn/css/hi/index<%=isLow?"l":"" %>.css" rel="stylesheet"
        type="text/css" />
    <link href="http://r.xieqj.cn/common/scrollpath.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="pageBody" ContentPlaceHolderID="htmlBody" runat="server">
  <nav>
        <ul>
            <li><a href="#start">技术特长</a></li>
            <li><a href="#description">项目</a></li>
            <li><a href="#syntax">我</a></li>            
        </ul>
    </nav>
    <div class="settings">
    <a href="http://www.miitbeian.gov.cn" style=" text-decoration:none; color:white;">京ICP备15011783号-1</a>
    邮箱:<a target="_blank" href="mailto:webadmin@war2045.com" style="text-decoration:none;color:white;">webadmin@war2045.com</a>
</div>
    <div class="wrapper">
          <div class="demo">
             <h1>技能介绍</h1>
              <p>&nbsp;&nbsp; C#、java、C、sql...总有我会的一种语言适合你、、、的项目，哈</p>
           <ul>
               <li>
                   <img src="http://r.xieqj.cn/imgs/hi/c.jpg" alt="c"/>简单的linux驱动、基于libevent的网络服务、基于opencv的图像处理
               </li>
                <li>
                   <img src="http://r.xieqj.cn/imgs/hi/csharp.jpg" alt="c#"/>winform桌面、web分布式系统尤为擅长
               </li>
                <li>
                   <img src="http://r.xieqj.cn/imgs/hi/java.png" alt="java"/>安卓小程序开发、基于hadoop框架的大数据分析功能开发
               </li>
                <li>
                   <img src="http://r.xieqj.cn/imgs/hi/javascript.jpg" alt="javascript"/>网页前端必备武器,js特效、前端业务实现，so easy
               </li>
                <li>
                   <img src="http://r.xieqj.cn/imgs/hi/sql.jpg" alt="sql"/>MS-sql是最熟悉的，mysql的语法使用时需要read the notebook
               </li>
           </ul>
        </div>

        <div class="description">
              <h1>项目介绍</h1>
            <ul>
                <li><a href="https://mds.codeplex.com/">小型分布式系统</a>
                    <p>提供十几台规模小型集群的分布式系统实现,包括用户系统、分布式缓存系统、日志系统、小型文件存储系统、分布式配置系统等。</p>
                    <p>系统设计目标减少常见互联网功能的基础代码开发工作，提供最简单的常见功能实现。</p>
                </li>
            </ul>
        </div>
        <div class="syntax">
            <h1>关于我</h1>
            <ul>
                <li>从事软件研发多年,软件战场老兵</li>
                <li>企业软件开发入行，最多的经验却是在互联网领域，最擅长分布式系统设计与实现</li>
                <li>喜欢技术，做有技术难度或者设计很酷的项目会不眠不休。但是不是宅男，更喜欢骑着车去远行</li>
                <li>专攻研究的领域：无人自动化在企业管理中的实现</li>
                <li>喜欢和很有想法的产品设计人员合作，完成他们设计很有成就感</li>
                <li><a href="http://blog.xieqj.cn" style="text-decoration:none;color:GrayText;"><h6>博客:http://blog.xieqj.cn</h6></a></li>
                <li>邮箱:<a target="_blank" href="mailto:xieqj@war2045.com" style="text-decoration:none;color:GrayText;">xieqj@war2045.com</a></li>
            </ul>           
        </div>

      
    </div>
</asp:Content>
<asp:Content ID="pageJs" ContentPlaceHolderID="jsWrap" runat="server">
    <script src="http://r.xieqj.cn/lib/jquery.easing.js"></script>
<script src="http://r.xieqj.cn/lib/jquery.scrollpath.js"></script>
    <script src="http://r.xieqj.cn/js/hi/index.js" type="text/javascript"></script>
</asp:Content>


