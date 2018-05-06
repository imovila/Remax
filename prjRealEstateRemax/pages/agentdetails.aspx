<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agentdetails.aspx.cs" Inherits="prjRealEstateRemax.pages.agentdetails" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Remax | Agent details</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,700,800' rel='stylesheet' type='text/css' />
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon" />
    <link rel="icon" href="favicon.ico" type="image/x-icon" />
    <link rel="stylesheet" href="../assets/css/normalize.css" />
    <link rel="stylesheet" href="../assets/css/font-awesome.min.css" />
    <link rel="stylesheet" href="../assets/css/fontello.css" />
    <link href="../assets/fonts/icon-7-stroke/css/pe-icon-7-stroke.css" rel="stylesheet" />
    <link href="../assets/fonts/icon-7-stroke/css/helper.css" rel="stylesheet" />
    <link href="../assets/css/animate.css" rel="stylesheet" media="screen" />
    <link rel="stylesheet" href="../assets/css/bootstrap-select.min.css" />
    <link rel="stylesheet" href="../bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../assets/css/icheck.min_all.css" />
    <link rel="stylesheet" href="../assets/css/price-range.css" />
    <link rel="stylesheet" href="../assets/css/owl.carousel.css" />  
    <link rel="stylesheet" href="../assets/css/owl.theme.css" />
    <link rel="stylesheet" href="../assets/css/owl.transitions.css" />
    <link rel="stylesheet" href="../assets/css/lightslider.min.css" />
    <link rel="stylesheet" href="../assets/css/style.css" />
    <link rel="stylesheet" href="../assets/css/responsive.css" />
    <style type="text/css">
        .auto-style1 {
            display: block;
            font-size: 13px;
            line-height: 1.42857;
            color: #838383;
            border-radius: 0px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
            box-shadow: 0px 1px 1px rgba(179, 179, 179, 0.1) inset;
            -webkit-transition: all 300ms linear;
            -o-transition: all 300ms linear;
            transition: border-color 0.15s ease-in-out 0s, box-shadow 0.15s ease-in-out 0s;
            -moz-transition: all 300ms linear;
            -ms-transition: all 300ms linear;
            border: 1px solid #DADADA;
            padding: 6px 12px;
            background-color: #FFF;
            background-image: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class=" form-inline">
    <div>
    
       <!-- Body content -->
       <div class="header-connect">
            <div class="container">
                <div class="row">
                    <div class="col-md-5 col-sm-8  col-xs-12">
                        <div class="header-half header-call">
                            <p>
                                <span><i class="pe-7s-call"></i>+1 234 567 7890</span>
                                <span><i class="pe-7s-mail"></i>email@remax.abc</span>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>        
        <!--End top header -->

        <nav class="navbar navbar-default ">
            <div class="container">

                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navigation">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="../index.aspx"><img src="../assets/img/logo.png" alt="" /></a>
                </div>

                <div class="collapse navbar-collapse yamm" id="navigation">
                    <ul class="main-nav nav navbar-nav navbar-right">
                        <li class="wow fadeInDown" data-wow-delay="0.2s"><a class="" href="../index.aspx">Home</a></li>
                        <li class="wow fadeInDown" data-wow-delay="0.2s"><a class="" href="./findagent.aspx">Find Agent</a></li>
                        <li class="wow fadeInDown" data-wow-delay="0.5s"><a class="" href="./contact.html">Contact</a></li>
                    </ul>
                </div><!-- /.navbar-collapse -->
            </div><!-- /.container-fluid -->
        </nav>
        <!-- End of nav bar -->

        <div class="page-head"> 
            <div class="container">
                <div class="row">
                    <div class="page-head-content">
                        <h1 class="page-title">
                            <asp:Literal ID="litAgentNameTitle" runat="server"></asp:Literal>&nbsp;-
                            <asp:Literal ID="litCityZoneTitle" runat="server"></asp:Literal>
                        </h1>               
                    </div>
                </div>
            </div>
        </div>
        <!-- End page header -->

        <!-- property area -->
        <div class="content-area single-property" style="background-color: #FCFCFC;">&nbsp;
            <div class="container">   

                <div class="clearfix padding-top-40" >

                    <div class="col-md-8 single-property-content prp-style-1">
                        <div class="row">
                            <div class="light-slide-item">            
                                <div class="clearfix">
                                      <asp:Literal ID="litPic" runat="server"></asp:Literal>
                                </div>
                            </div>
                        </div>
                        <br /><br />
                        <div class="single-property-wrapper">
                            <div class="single-property-header">                                          
                                <h1 class="property-title pull-left">
                                    <asp:Literal ID="litAgentName" runat="server"></asp:Literal>
                                </h1>
                                <span class="property-price pull-right">Spoken&nbsp;<asp:Literal ID="litLang" runat="server"></asp:Literal></span>
                            </div>

                            <div class="section">
                                <h4 class="s-property-title">Code</h4>
                                <div class="s-property-content">
                                    <p><asp:Literal ID="litCode" runat="server"></asp:Literal></p>
                                </div>
                            </div>
                            <!-- End code area -->

                            <div class="section">
                                <h4 class="s-property-title">City Zone</h4>
                                <div class="s-property-content">
                                    <p><asp:Literal ID="litCityZone" runat="server"></asp:Literal></p>
                                </div>
                            </div>
                            <!-- End gender area -->

                             <div class="section">
                                <h4 class="s-property-title">Gender</h4>
                                <div class="s-property-content">
                                    <p><asp:Literal ID="litGender" runat="server"></asp:Literal></p>
                                </div>
                            </div>
                            <!-- End gender area -->

                                                        
                        </div>
                    </div>

                    <!-- Agent -->
                    <div class="col-md-4 p0">
                        <aside class="sidebar sidebar-property blog-asside-right">
                            <div class="dealer-widget">
                                <div class="dealer-content">
                                    <div class="inner-wrapper">

                                        <div class="clear">
                                            For any details write to me
                                        </div>

                                    </div>
                                </div>
                            </div>
                            <!-- End Agent -->
        

                            <div class="panel panel-default sidebar-menu wow fadeInRight animated" >
                                <div class="panel-heading">
                                    <h3 class="panel-title">Send a private message to the agent</h3>
                                </div>
                                <div class="panel-body search-widget">
                                    
                                        <fieldset>
                                            <div class="row">
                                                <div class="col-xs-12">
                                                    <asp:TextBox ID="txtMessage" runat="server" CssClass="auto-style1" placeholder="Write the message here" Height="200px" TextMode="MultiLine" Width="350px"></asp:TextBox>
                                                </div>
                                            </div>
                                        </fieldset>

                                    
                                        <fieldset >
                                            <div class="row">
                                                <div class="col-xs-12">  
                                                    <asp:Button ID="btnSend" runat="server" Text="Send" CssClass="button btn largesearch-btn" OnClick="btnSend_Click"/>
                                                </div>  
                                            </div>
                                        </fieldset>                                     
                                
                                </div>
                            </div>

                        </aside>
                    </div>
                </div>

            </div>
        </div>


        <!-- Footer area-->
        <div class="footer-area">

            <div class=" footer">
                <div class="container">

                        <div class="wow fadeInRight animated">
                            <div class="single-footer">
                                <h4>About us </h4>
                                <div class="footer-title-line"></div>

                                <img src="assets/img/footer-logo.png" alt="" class="wow pulse" data-wow-delay="1s" />
                                <p>Lorem ipsum dolor cum necessitatibus su quisquam molestias. Vel unde, blanditiis.</p>
                                    <i class="pe-7s-map-marker strong"> </i> 1234 av. Lorem ipsum
                                    <i class="pe-7s-mail strong"> </i> email@remax.abc
                                    <i class="pe-7s-call strong"> </i> +1 234 567 8901
                            </div>
                        </div>

                </div>
            </div>

            <div class="footer-copy text-center">
                <div class="container">
                    <div class="row">
                        <div class="pull-left">
                            <span> (C) Remax, 2018  </span> 
                        </div>
                        <div class="bottom-menu pull-right"> 
                            <ul> 
                                <li><a class="wow fadeInUp animated" href="../index.aspx" data-wow-delay="0.2s">Home</a></li>
                                <li><a class="wow fadeInUp animated" href="./findagent.aspx" data-wow-delay="0.2s">Find agent</a></li>
                                <li><a class="wow fadeInUp animated" href="./contact.html" data-wow-delay="0.6s">Contact</a></li>
                            </ul> 
                        </div>
                    </div>
                </div>
            </div>

        </div>
        

    </div>
    </form>

    <script src="../assets/js/vendor/modernizr-2.6.2.min.js"></script>
    <script src="../assets/js/jquery-1.10.2.min.js"></script>
    <script src="../bootstrap/js/bootstrap.min.js"></script>
    <script src="../assets/js/bootstrap-select.min.js"></script>
    <script src="../assets/js/bootstrap-hover-dropdown.js"></script>
    <script src="../assets/js/easypiechart.min.js"></script>
    <script src="../assets/js/jquery.easypiechart.min.js"></script>
    <script src="../assets/js/owl.carousel.min.js"></script>
    <script src="../assets/js/wow.js"></script>
    <script src="../assets/js/icheck.min.js"></script>
    <script src="../assets/js/price-range.js"></script>
    <script type="text/javascript" src="../assets/js/lightslider.min.js"></script>
    <script src="../assets/js/main.js"></script>

</body>
</html>