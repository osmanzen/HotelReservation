<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="reservation.aspx.cs" Inherits="HotelReservation.UI.reservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                        <input id="guestCount" name="room" type="text" class="form-control" placeholder="Kişi Sayısı" />
                    </div>
                </div>
                <div class="form-group col-lg-2 col-md-2 col-sm-2 col-xs-12 floatright">
                    <a id="btnBook" class="btn btn-warning btn-md floatright">Rezervasyon <i class="fa fa-search" aria-hidden="true"></i></a>
                </div>

            </div>
        </div>
    </div>
    <!-- end hotel booking -->

    <asp:Panel ID="pnlDurum" runat="server" Visible="false">
        <div class="container alert alert-warning" role="alert">
            <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
            <span class="sr-only">Hata:</span> <span>Seçilen Tarihlerde Boş Odamız Bulunmamaktadır. Lütfen Farklı Bir Tarih Giriniz.</span>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnlLogin" runat="server" Visible="false">
        <div class="container alert alert-warning" role="alert">
            <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
            <span class="sr-only">Hata:</span> <span>Rezervasyon Yapmak İçin Lütfen Oturum Açın..</span>
        </div>
    </asp:Panel>

    <asp:Panel ID="Panel1" runat="server" Visible="false">
        <div class="container">
            <div class="row clearfix">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="card">
                        <div class="header center-block bg-blue text-center">
                            <div class="well">
                            <h2>Rezervasyon Formu</h2>
                            </div>
                        </div>
                        <div class="body">
                            <asp:Table ID="tblGuests" runat="server" style="margin-top:3%" CssClass="table table-striped">
                                <asp:TableRow>
                                    <asp:TableHeaderCell>#</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Kimlik Numarası</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Misafir Adı</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Misafir Soyadı</asp:TableHeaderCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <div class="container">
            <asp:Panel ID="pnlOdalar" runat="server"></asp:Panel>
        </div>

        <div class="container">
                    <asp:RadioButtonList CssClass="table table-responsive" ID="rdbListOda" runat="server" RepeatLayout="Table" RepeatColumns="3" Font-Size="Large">
                    </asp:RadioButtonList>

            <asp:Button ID="btnKaydet" CssClass="btn btn-block btn-lg" runat="server" Text="Rezervasyon Oluştur" OnClick="btnKaydet_Click" UseSubmitBehavior="False" />
        </div>
        
    </asp:Panel>

</asp:Content>
