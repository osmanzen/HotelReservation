<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="HotelReservation.UI.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- start breadcrumb -->
        <section class="breadcrumb_main_area margin-bottom-0">
            <div class="container-fluid">
                <div class="row">
                    <div class="breadcrumb_main nice_title">
                        <h2>İletişim</h2>
                        <!-- special offer start -->
                        <div class="special_offer_main">
                         <img style="z-index:1;position: absolute; top: 25px;left: 0px;" src="img/accomodation-breadcrumb.jpg" />
                        <img style="z-index:2;position: absolute; top: 25px;left: 1100px;" src="img/special-offer-yellow-main.png" alt="imf">
                    </div>  
                        <!-- end offer start -->
                    </div>
                </div>
            </div>            
        </section>
        <!-- end breadcrunb -->
     <!-- start other detect room section -->
        <div class="contact_google_map_area margin-bottom-75">
            <div class="container">
                <div class="contact_google_map">
                    <div id="contactgoogleMap" style="width:100%;height:374px;"></div>
                </div>
            </div>
        </div>

    <!-- start contact mail area -->
        <section class="contact_mail_area margin-bottom-90">
            <div class="container">
                <div class="row">
                    <div class="contact_mail">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                            <div class="send_mail">
                                <div class="section_title margin-bottom-40">
                                    <h4>Bize Mesaj Atın</h4>
                                </div>
                                <form action="contact_process.php" method="post">
                                    <div class="row">
                                        <div class="col-lg-6 col-md-6">
                                            <input type="text" placeholder="İSİM *" name="fname" required>
                                        </div>
                                        <div class="col-lg-6 col-md-6">
                                            <input type="text" placeholder="sOYİSİM *" required name="lname">
                                        </div>
                                        <div class="col-lg-6 col-md-6">
                                            <input  type="text" placeholder="EMAİL ADRESİNİZ *" required name="email"/>
                                        </div>
                                        <div class="col-lg-6 col-md-6">
                                            <input  type="text" placeholder="Telefon Numaranız *" required name="phone"/>
                                        </div>
                                        <div class="col-lg-12 col-md-12">
                                            <textarea name="message" placeholder="Mesaj" required></textarea>
                                        </div>
                                        <div class="col-lg-4 col-md-4">
                                            <!-- <a href="#" class="btn btn-warning btn-md"></a> -->
                                            <input class="btn btn-warning btn-md" type="submit" name="submit" value="GÖNDER" />
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                            <div class="contact_info margin-top-65">
                                <div class="section_title margin-bottom-45">
                                    <h4>İLETİŞİM BİLGİSİ</h4>
                                </div>
                                <ul class="clearul">
                                    <li>
                                        <i class="fa fa-map-marker"></i>
                                        Taksim,İstanbul <br>
                                        TÜRKİYE
                                    </li>
                                    <li>    
                                        <i class="fa fa-phone"></i>
                                        0(242) 316 10 10
                                    </li>
                                    <li>
                                        <i class="fa fa-envelope-o"></i>
                                        info@hotelbooking.com
                                    </li>
                                </ul>
                                <div class="social_icons clearfix">
                                    <ul class="clearul">
                                        <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                        <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                        <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                                        <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- end contact mail area -->

		
</asp:Content>
