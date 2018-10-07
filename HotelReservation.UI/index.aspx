<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HotelReservation.UI.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="main_slider_area">
        <div class="container-fluid">
            <div class="row">
                <div class="main_slider" id="slider_rev">
                    <!-- special offer start -->
                    <div class="special_offer_main hidden-xs">
                        <%--<img src="img/special-offer-yellow-main.png" alt="">--%>
                    </div>
                    <!-- end offer start -->

                    <div class="fullwidthbanner-container">
                        <div class="fullwidth_home_two_banner">
                            <ul>
                                <li data-transition="random" data-slotamount="7" data-masterspeed="1000">
                                    <img src="img/rev-slider/slider-one.jpg" alt="slide">
                                    <div class="tp-caption large_black sfr" data-x="105" data-y="197" data-speed="1200" data-start="1100" data-easing="easeInOutBack"
                                        style="font-family: 'Playfair Display', serif; font-size: 48px; color: #131e2a; margin-bottom: 23px; text-transform: uppercase; line-height: 40px;">
                                        Book Your Summer Holidays
                                    </div>
                                    <div class="tp-caption large_black sfr" data-x="105" data-y="255" data-speed="1500" data-start="1400" data-easing="easeInOutBack"
                                        style="font-family: 'Playfair Display', serif; font-size: 48px; color: #131e2a; margin-bottom: 23px; text-transform: uppercase; line-height: 40px;">
                                        With HOTEL BOOKING Template
                                    </div>
                                    <div class="tp-caption lfb carousel-caption-inner" data-x="105" data-y="313" data-speed="1300" data-start="1700" data-easing="easeInOutBack"
                                        style="background: #f7c411; padding: 10px; cursor: pointer;">
                                        <a href="#" class="" style="background: #f7c411; border-radius: 0; color: #313a45; display: inline-block; font-size: 18px; padding: 8px 34px; text-transform: uppercase; border: 1px solid #9e811a;">Explore IT</a>
                                    </div>
                                </li>
                                <li data-transition="random" data-slotamount="7" data-masterspeed="1000">
                                    <img src="img/rev-slider/slider-two.jpg" alt="slide">
                                    <div class="tp-caption large_black sfr" data-x="105" data-y="197" data-speed="1200" data-start="1100" data-easing="easeInOutBack"
                                        style="font-family: 'Playfair Display', serif; font-size: 48px; color: #131e2a; margin-bottom: 23px; text-transform: uppercase; line-height: 40px;">
                                        One of the Best Booking Template
                                    </div>
                                    <div class="tp-caption large_black sfr" data-x="105" data-y="255" data-speed="1500" data-start="1400" data-easing="easeInOutBack"
                                        style="font-family: 'Playfair Display', serif; font-size: 48px; color: #131e2a; margin-bottom: 23px; text-transform: uppercase; line-height: 40px;">
                                        Available on Envato Market
                                    </div>
                                    <div class="tp-caption lfb carousel-caption-inner" data-x="105" data-y="313" data-speed="1300" data-start="1700" data-easing="easeInOutBack"
                                        style="background: #f7c411; padding: 10px; cursor: pointer;">
                                        <a href="#" class="" style="background: #f7c411; border-radius: 0; color: #313a45; display: inline-block; font-size: 18px; padding: 8px 34px; text-transform: uppercase; border: 1px solid #9e811a;">Explore IT</a>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <!-- start hotel booking -->
                    
                    <div class="hotel_booking_area" style="margin-bottom: 50px;">
                        <div class="container">
                            <div class="hotel_booking">
                                <div class="col-lg-2 col-md-3 col-sm-3">
                                    <div class="room_book border-right-dark-1">
                                        <h6>Online</h6>
                                        <h6>Rezervasyon</h6>
                                    </div>
                                </div>
                                <div class="form-group col-lg-3 col-md-2 col-sm-2">
                                    <div class="input-group border-bottom-dark-2">
                                        <input class="date-picker" id="datepicker" placeholder="GİRİŞ TARİHİ" type="text" />
                                        <div class="input-group-addon"><i class="fa fa-calendar"></i></div>
                                    </div>
                                </div>
                                <div class="form-group col-lg-3 col-md-2 col-sm-2">
                                    <div class="input-group border-bottom-dark-2">
                                        <input class="date-picker" id="datepicker1" placeholder="ÇIKIŞ TARİHİ" type="text" />
                                        <div class="input-group-addon"><i class="fa fa-calendar"></i></div>
                                    </div>
                                </div>
                                <div class="col-lg-2 col-md-2 col-sm-2">
                                    <div class="input-group border-bottom-dark-2">
                                        <input id="guestCount" name="room" type="number" class="form-control" placeholder="Kişi Sayısı" />
                                    </div>
                                </div>
                                <div class="form-group col-lg-2 col-md-2 col-sm-2 col-xs-12 floatright">
                                    <a id="btnBook" class="btn btn-warning btn-md floatright">Rezervasyon <i class="fa fa-search" aria-hidden="true"></i></a>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- end hotel booking -->
                </div>
            </div>
        </div>
    </div>
    <!-- end main slider -->

</asp:Content>
