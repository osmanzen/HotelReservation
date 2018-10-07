<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="konaklama.aspx.cs" Inherits="HotelReservation.UI.konaklama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="breadcrumb_main_area margin-bottom-0">
        <div class="container-fluid">
            <div class="row">
                <div class="breadcrumb_main nice_title">
                    <h2>Konaklama</h2>
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
    <div>
        <section class="another_facitilies_area" style="margin-top:0px; margin-bottom:30px;">
            <div class="container">
                <h3>KONAKLAMA GENEL BAKIŞ</h3>

                <p style="margin-top:10px;">
                    Hotel Booking, İstanbul; misafirlerinin ihtiyaçlarını karşılamak üzere 497 geniş oda ve süitleri ile üst düzey hizmet ve özel
            yaşam alanı sunarken, şehir hayatının tüm ihtiyaçlarını karşılamaktadır. Hotel Booking'in rezidans Bölümü, HotelBooking Living 
            ise uzun veya kısa süreli konaklama imkanı sunmakta olup stüdyolardan üç yatak odalı suitlere kadar 63 lüks suite ile İstanbul 
            deneyiminizi tıpkı bir İstanbul’lu gibi yaşamanızı sağlayacaktır.
                </p>
            </div>
        </section>
    </div>
    <!-- start Hotel Facilities section -->
        <section class="select_room_area padding-top-5 margin-bottom-90">
            <div class="container">
                <div class="row">
                    <div class="select_room clearfix">
                        <div class="section_title nice_title text-center">
                            <h3>Özel Odalar</h3>
                        </div>
                        <div class="select_room_content clearfix">
                            <div class="col-lg-8 col-md-8 col-sm-8 col-xs-12">
                                <div class="room_thumb">
                                    <a href="#"><img src="img/room-thumb-one.jpg" alt=""></a>
                                    <div class="room_details">
                                        <div class="about_room floatleft">
                                            <div class="room_quality floatleft">
                                                <h5>Deluxe Oda</h5>
                                            </div>
                                            <div class="room_rent floatleft">
                                                <p>$180<span> / night</span></p>
                                            </div>
                                        </div>
                                        <div class="room_block floatright">
                                            <a href="#" class="btn btn-black">Book</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-4 col-md-4 col-sm-4 col-sx-12">
                                <div class="room_thumb small_room_thumb margin-bottom-35">
                                    <a href="#"><img src="img/room-thumb-two.jpg" alt=""></a>
                                    <div class="room_details">
                                        <div class="about_room floatleft">
                                            <div class="room_quality floatleft">
                                                <h5>Deluxe Oda</h5>
                                            </div>
                                            <div class="room_rent floatleft">
                                                <p>$180<span> / night</span></p>
                                            </div>
                                        </div>
                                        <div class="room_block floatright">
                                            <a href="#" class="btn btn-black">Book</a>
                                        </div>
                                    </div>
                                </div>
                                <div class="room_thumb small_room_thumb">
                                    <a href="#"><img src="img/room-thumb-three.jpg" alt=""></a>
                                    <div class="room_details">
                                        <div class="about_room floatleft">
                                            <div class="room_quality floatleft">
                                                <h5>Deluxe Oda</h5>
                                            </div>
                                            <div class="room_rent floatleft">
                                                <p>$180<span> / night</span></p>
                                            </div>
                                        </div>
                                        <div class="room_block floatright">
                                            <a href="#" class="btn btn-black">Book</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- end Hotel Facilities section -->

    <!-- start single room details -->
                            <div class="accomodation_single_room">
                                <div class="container">
                                    <div class="row">
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-ten.jpg" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Deluxe Oda</h6>
                                                                <p>$130/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Elegant Oda</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$130/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-nineteen.png" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Single Oda</h6>
                                                                <p>$140/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Single Oda</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$140/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-thirteen.jpg" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Double Oda</h6>
                                                                <p>$200/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Double Oda</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$200/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-fourteen.jpg" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Child Oda</h6>
                                                                <p>$100/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Child Room</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$100/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-fifteen.png" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Couple Oda</h6>
                                                                <p>$160/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Couple Oda</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$160/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-twenty.png" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Elegant Oda</h6>
                                                                <p>$250/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Elegant Oda</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$250/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-seventeen.png" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Personal Oda</h6>
                                                                <p>$170/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Personal Oda</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$170/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-md-3 col-sm-3">
                                            <div class="single_room_wrapper clearfix padding-bottom-30">
                                                <figure class="uk-overlay uk-overlay-hover">
                                                    <div class="room_media">
                                                        <a href="#"><img src="img/room-image-eighteen.png" alt=""></a>
                                                    </div>
                                                    <div class="room_title border-bottom-whitesmoke clearfix">
                                                            <div class="left_room_title floatleft">
                                                                <h6>Deluxe Oda</h6>
                                                                <p>$190/ <span>night</span></p>
                                                            </div>
                                                            <div class="left_room_title floatright">
                                                                <a href="#" class="btn">Book</a>
                                                            </div>
                                                        </div>
                                                    <div class="uk-overlay-panel uk-overlay-background single_wrapper_details clearfix animated bounceInDown">
                                                        <div class="border-dark-1 padding-22 clearfix single_wrapper_details_pad">
                                                            <h5>Deluxe Oda</h5>
                                                            <p>
                                                                Semper ac dolor vitae accumsan. interdum hendrerit lacinia.
                                                            </p>
                                                            <p>
                                                                Phasellus accumsan urna vitae molestie interdum.
                                                            </p>
                                                            <div class="single_room_cost clearfix">
                                                                <div class="floatleft">
                                                                    <p>$190/ <span>night</span></p>
                                                                </div>
                                                                <div class="floatright">
                                                                    <a href="#" class="btn">Book</a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </figure>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <nav class="text-center margin-top-65 margin-bottom-75">
                                          <ul class="pagination">
                                            <li>
                                              <a href="#" aria-label="Previous">
                                                <i class="fa fa-angle-left"></i>prev
                                              </a>
                                            </li>
                                            <li class="active"><a href="#">1</a></li>
                                            <li><a href="#">2</a></li>
                                            <li><a href="#">3</a></li>
                                            <li><a href="#">4</a></li>
                                            <li><a href="#">5</a></li>
                                            <li>
                                              <a href="#" aria-label="Next">next
                                                <i class="fa fa-angle-right"></i>
                                              </a>
                                            </li>
                                          </ul>
                                        </nav>
                                    </div>
                                </div>
                            </div>
                            <!-- end single room details -->
</asp:Content>
