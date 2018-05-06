<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prjRealEstateRemax.index" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Remax | Home page</title>
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,700,800' rel='stylesheet' type='text/css' />
        <link rel="shortcut icon" href="favicon.ico" type="image/x-icon" />
        <link rel="icon" href="favicon.ico" type="image/x-icon" />
        <link rel="stylesheet" href="assets/css/normalize.css" />
        <link rel="stylesheet" href="assets/css/font-awesome.min.css" />
        <link rel="stylesheet" href="assets/css/fontello.css" />
        <link href="assets/fonts/icon-7-stroke/css/pe-icon-7-stroke.css" rel="stylesheet" />
        <link href="assets/fonts/icon-7-stroke/css/helper.css" rel="stylesheet" />
        <link href="assets/css/animate.css" rel="stylesheet" media="screen" />
        <link rel="stylesheet" href="assets/css/bootstrap-select.min.css" /> 
        <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css" />
        <link rel="stylesheet" href="assets/css/icheck.min_all.css" />
        <link rel="stylesheet" href="assets/css/price-range.css" />
        <link rel="stylesheet" href="assets/css/owl.carousel.css" />  
        <link rel="stylesheet" href="assets/css/owl.theme.css" />
        <link rel="stylesheet" href="assets/css/owl.transitions.css" />
        <link rel="stylesheet" href="assets/css/style.css" />
        <link rel="stylesheet" href="assets/css/responsive.css" />
</head>
<body>
 
    <form id="form1" runat="server" class="form-inline">

        <div class="header-connect">
            <div class="container">
                <div class="row">
                    <div class="col-md-5 col-sm-8  col-xs-12">
                        <div class="header-half header-call">
                            <p>
                                <span><i class="pe-7s-call"></i> +1 234 567 7890</span>
                                <span><i class="pe-7s-mail"></i> email@remax.abc</span>
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
                    <a class="navbar-brand" href="index.html"><img src="assets/img/logo.png" alt="" /></a>
                </div>

                <div class="collapse navbar-collapse yamm" id="navigation">
                    <ul class="main-nav nav navbar-nav navbar-right">
                        <li class="wow fadeInDown" data-wow-delay="0.2s"><a class="" href="pages/findagent.aspx">Find Agent</a></li>
                        <li class="wow fadeInDown" data-wow-delay="0.5s"><a class="" href="pages/contact.html">Contact</a></li>
                    </ul>
                </div><!-- /.navbar-collapse -->
            </div><!-- /.container-fluid -->
        </nav>
        <!-- End of nav bar -->

        <div class="slider-area">
            <div class="slider">
                <div id="bg-slider" class="owl-carousel owl-theme">

                    <div class="item"><img src="assets/img/slide1/slider-image-1.jpg" alt="" /></div>
                    <div class="item"><img src="assets/img/slide1/slider-image-2.jpg" alt="" /></div>
                    <div class="item"><img src="assets/img/slide1/slider-image-3.jpg" alt="" /></div>

                </div>
            </div>
            
            <div class="slider-content">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1 col-sm-12">
                        <h2>Remax Real Estate </h2>
                        <h2>property Searching Just Got So Easy</h2>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eligendi deserunt deleniti, ullam commodi sit ipsam laboriosam velit adipisci quibusdam aliquam teneturo!</p>
                        <div class="search-form wow pulse" data-wow-delay="0.8s">

                                <button class="btn toggle-btn" type="button"><i class="fa fa-bars"></i></button>

                                <div class="form-group">
                                    <asp:DropDownList ID="cboHouseType" runat="server" CssClass="selectpicker" data-live-search="true" data-live-search-style="begins" title="Select house type">
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">                                   
                                    <asp:DropDownList ID="cboCityZone" runat="server" CssClass="selectpicker" data-live-search="true" data-live-search-style="begins" title="Select your city zone">
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                     <asp:DropDownList ID="cboStatus" runat="server" CssClass="selectpicker" data-live-search="true" data-live-search-style="begins" title="Select house status">
                                    </asp:DropDownList>
                                </div>

                                <asp:Button ID="btnSubmit" runat="server" Text="Search" CssClass="btn search-btn" OnClick="btnSubmit_Click"/>
                            
                                <div style="display: none;" class="search-toggle">

                                    <div class="search-row">   

                                        <div class="form-group mar-r-20">
                                            <label for="property-geo">Price from (CAD):</label>
                                            <asp:DropDownList ID="cboPriceFrom" runat="server"  CssClass="selectpicker" data-live-search="true" data-live-search-style="begins" title="Select price from">
                                            </asp:DropDownList>
                                        </div>
                                        <!-- End of  -->  

                                        <div class="form-group mar-l-20">
                                            <label for="property-geo">Price To (CAD):</label>
                                            <asp:DropDownList ID="cboPriceTo" runat="server"  CssClass="selectpicker" data-live-search="true" data-live-search-style="begins" title="Select price to">
                                            </asp:DropDownList>
                                        </div>
                                        <!-- End of  --> 
                                    </div>

                                    <div class="search-row">

                                        <div class="form-group mar-r-20">
                                            <label for="property-geo">Rooms:</label>
                                            <asp:DropDownList ID="cboRooms" runat="server"  CssClass="selectpicker" data-live-search="true" data-live-search-style="begins" title="Select number of rooms">
                                            </asp:DropDownList>
                                        </div>
                                        <!-- End of  --> 

                                        <div class="form-group mar-l-20">
                                            <label for="property-geo">Bathrooms:</label>
                                            <asp:DropDownList ID="cboBathrooms" runat="server"  CssClass="selectpicker" data-live-search="true" data-live-search-style="begins" title="Select number of bathrooms">
                                            </asp:DropDownList>
                                        </div>
                                        <!-- End of  --> 

                                    </div>
                                    <br />
                                    <div class="search-row">  

                                    <!-- End of  --> 
                                    <br />  <br />  <br />
                                    <hr />
                                    </div>                
                                </div>                    

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- houses area -->
        <div class="content-area home-area-1 recent-property" style="background-color: #EAEAEA; padding-bottom: 55px;">
            <div class="container">
                <div class="row">
                    <div class="col-md-10 col-md-offset-1 col-sm-12 text-center page-title">
                        <!-- /.feature title -->
                        <h2><asp:Literal ID="LitResTitle" runat="server"></asp:Literal></h2>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Suspendisse ultricies commodo arcu nec pretium. Nullam sed arcu ultricies. </p>
                    </div>
                </div>

                <div class="row">
                    <div class="proerty-th">

                        <asp:Literal ID="litInfoHouse" runat="server"></asp:Literal>
                        
                    </div>
                </div>
            </div>
        </div>

        <!--TESTIMONIALS -->
        <div class="testimonial-area recent-property" style="background-color: #FCFCFC; padding-bottom: 15px;">
            <div class="container">
                <div class="row">
                    <div class="col-md-10 col-md-offset-1 col-sm-12 text-center page-title">
                        <!-- /.feature title -->
                        <h2>Our agents are always here</h2> 
                    </div>                        
                </div>

                <div class="row">
                    <div class="row testimonial">
                        <div class="col-md-12">
                            <div id="testimonial-slider">

                                <asp:Literal ID="litInfoAgent" runat="server"></asp:Literal>
                                
                            </div>
                        </div>
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
                                <li><a class="wow fadeInUp animated" href="index.aspx" data-wow-delay="0.2s">Home</a></li>
                                <li><a class="wow fadeInUp animated" href="pages/contact.html" data-wow-delay="0.6s">Contact</a></li>
                            </ul> 
                        </div>
                    </div>
                </div>
            </div>

        </div>


    </form>

    <script src="assets/js/modernizr-2.6.2.min.js"></script>

    <script src="assets/js/jquery-1.10.2.min.js"></script> 
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/bootstrap-select.min.js"></script>
    <script src="assets/js/bootstrap-hover-dropdown.js"></script>

    <script src="assets/js/easypiechart.min.js"></script>
    <script src="assets/js/jquery.easypiechart.min.js"></script>

    <script src="assets/js/owl.carousel.min.js"></script>
    <script src="assets/js/wow.js"></script>

    <script src="assets/js/icheck.min.js"></script>
    <script src="assets/js/price-range.js"></script>

    <script src="assets/js/main.js"></script>

</body>
</html>
