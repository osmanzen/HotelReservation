using HotelReservation.BLL;
using ModelClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelReservation.UI
{
    public partial class reservation : System.Web.UI.Page
    {
        RoomManagementBLL _roomManagement = new RoomManagementBLL();
        RoomReservationManagementBLL _roomReservationManagement = new RoomReservationManagementBLL();
        ReservationTypeManagementBLL _reservationTypeManagement = new ReservationTypeManagementBLL();
        ReservationManagementBLL _reservationManagement = new ReservationManagementBLL();
        GuestManagementBLL _guestManagement = new GuestManagementBLL();
        ReservationGuestManagementBLL _reservationGuestManagement = new ReservationGuestManagementBLL();


        List<TextBox> tcList, nameList, lastNameList;
        DateTime dtGiris, dtCikis;
        int kisiSayisi;
        List<int> bosOdalar, tumOdalar, seciliOdalar;
        List<CheckBox> odaBox;
        decimal standartFiyat, fullFiyat, fullFullFiyat;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (isMember())
            {
                if (Request.QueryString["arrival"] != null && Request.QueryString["departure"] != null && Request.QueryString["guestcount"] != null)
                {
                    Panel1.Visible = true;
                    dtGiris = Convert.ToDateTime(Request.QueryString["arrival"]).Date;
                    dtCikis = Convert.ToDateTime(Request.QueryString["departure"]).Date;
                    kisiSayisi = int.Parse(Request.QueryString["guestcount"]);
                    bosOdalar = _roomReservationManagement.BosOdalar(dtGiris, dtCikis);
                    tumOdalar = _roomManagement.TumOdalar();

                    if (bosOdalar.Count * 3 >= kisiSayisi)
                    {
                        odaBoxOlustur(bosOdalar, tumOdalar);

                        FormTablosuOlustur(kisiSayisi);

                        standartFiyat = FaturaHesapla(dtGiris, dtCikis, kisiSayisi, 1);
                        fullFiyat = FaturaHesapla(dtGiris, dtCikis, kisiSayisi, 2);
                        fullFullFiyat = FaturaHesapla(dtGiris, dtCikis, kisiSayisi, 3);

                        rdbListOda.Items.Add("Standart Oda: " + string.Format("{0:0,0.00}", standartFiyat) + " TL");
                        rdbListOda.Items.Add("Full Oda: " + string.Format("{0:0,0.00}", fullFiyat) + " TL");
                        rdbListOda.Items.Add("Full+Full Oda: " + string.Format("{0:0,0.00}", fullFullFiyat) + " TL");
                    }
                    else
                    {
                        Panel1.Visible = false;
                        pnlDurum.Visible = true;
                    }
                }
            }
            else
            {
                Panel1.Visible = false;
                pnlLogin.Visible = true;
            }

        }

        private decimal FaturaHesapla(DateTime girisTarihi, DateTime cikisTarihi, int kisiSayisi, int odaTipi)
        {
            decimal gunlukFiyat = 100M;
            decimal rezFiyat;

            ReservationType rType = _reservationTypeManagement.ReservationTypeDondur(odaTipi);
            gunlukFiyat = rType.Price;

            decimal faturaTutari = 0;
            DateTime KayitTarihi;
            for (int i = 0; i < cikisTarihi.Subtract(girisTarihi).TotalDays; i++)
            {
                KayitTarihi = girisTarihi.AddDays(i);
                rezFiyat = gunlukFiyat;

                if (KayitTarihi.DayOfWeek.ToString() == "Sunday" || KayitTarihi.DayOfWeek.ToString() == "Saturday")
                {
                    rezFiyat *= 1.30M;
                }

                if (kisiSayisi % 3 == 2)
                {
                    faturaTutari += rezFiyat;
                }
                else if (kisiSayisi % 3 == 1)
                {
                    faturaTutari += (rezFiyat * 0.70M);
                }

                if (kisiSayisi / 3 == 1)
                {
                    faturaTutari += rezFiyat * 1.20M;
                }
                else if ((kisiSayisi / 3) > 1)
                {
                    for (int j = 0; j <= kisiSayisi - 3; j += 3)
                    {
                        faturaTutari += (rezFiyat * 1.20M);
                    }
                }
            }
            return faturaTutari;
        }

        private void FormTablosuOlustur(int kisiSayisi)
        {
            tcList = new List<TextBox>();
            nameList = new List<TextBox>();
            lastNameList = new List<TextBox>();

            TextBox txt;
            TableRow tr;
            TableCell tc;

            for (int i = 0; i < kisiSayisi; i++)
            {
                tr = new TableRow();

                tc = new TableCell();
                Literal lt = new Literal();
                lt.Text = (i + 1) + ". Misafir";
                tc.Controls.Add(lt);
                tr.Controls.Add(tc);

                tc = new TableCell();
                txt = new TextBox();
                txt.ID = "txtTC" + i;
                txt.MaxLength = 11;
                txt.CssClass = "form-control";
                tcList.Add(txt);
                tc.Controls.Add(txt);
                tr.Controls.Add(tc);

                tc = new TableCell();
                txt = new TextBox();
                txt.ID = "txtName" + i;
                txt.CssClass = "form-control";
                nameList.Add(txt);
                tc.Controls.Add(txt);
                tr.Controls.Add(tc);

                tc = new TableCell();
                txt = new TextBox();
                txt.ID = "txtLastName" + i;
                txt.CssClass = "form-control";
                lastNameList.Add(txt);
                tc.Controls.Add(txt);
                tr.Controls.Add(tc);
                tblGuests.Controls.Add(tr);
            }
        }

        private bool isMember()
        {
            return Session["user"] != null;
        }

        private void odaBoxOlustur(List<int> bosOdalar, List<int> tumOdalar)
        {
            odaBox = new List<CheckBox>();
            CheckBox chb;
            Table tb = new Table();
            tb.CssClass = "table";
            TableRow tr;
            TableCell tc;
            int secilecekOdaSayisi = Convert.ToInt32(Math.Ceiling(kisiSayisi / 3M));
            seciliOdalar = new List<int>();
            int roomIndex = 0;
            for (int i = 0; i < tumOdalar.Count / 10; i++)
            {
                tr = new TableRow();

                for (int j = 0; j < 10; j++)
                {

                    chb = new CheckBox();
                    chb.Text = tumOdalar[roomIndex].ToString();
                    chb.ID = tumOdalar[roomIndex].ToString();
                    chb.Enabled = false;
                    tc = new TableCell();
                    if (bosOdalar.Contains(tumOdalar[roomIndex]))
                    {
                        if (secilecekOdaSayisi > 0)
                        {
                            chb.Checked = true;
                            seciliOdalar.Add((tumOdalar[roomIndex]));
                            secilecekOdaSayisi--;
                        }
                        tc.CssClass = "bosOda";
                        odaBox.Add(chb);
                    }
                    else
                    {
                        tc.CssClass = "doluOda";
                    }
                    tc.Controls.Add(chb);
                    tr.Controls.Add(tc);
                    roomIndex++;
                }

                tb.Controls.Add(tr);
            }
            pnlOdalar.Controls.Add(tb);
        }


        protected void btnKaydet_Click(object sender, EventArgs e)
        {
                Guid reservationID = Guid.NewGuid();

                decimal faturaTutari = 0;
                switch (rdbListOda.SelectedIndex)
                {
                    case 0: faturaTutari = standartFiyat; break;
                    case 1: faturaTutari = fullFiyat; break;
                    case 2: faturaTutari = fullFullFiyat; break;
                }

                //FATURA TUTARI SEÇİLDİ

                _reservationManagement.ReservationAdd(reservationID, new Guid(Session["user"].ToString()), rdbListOda.SelectedIndex + 1, faturaTutari);

                //REZERVASYON OLUŞTURULDU

                GuestEkle(reservationID);

                //GUESTLER EKLENDİ VE REZERVASYONA BAĞLANDI

                RoomReserved(reservationID);

                //ODALAR DOLDURULDU

                Response.Redirect("memberinfo.aspx");
        }

        private void GuestEkle(Guid reservationID)
        {
            Guid guestID;

            for (int i = 0; i < kisiSayisi; i++)
            {
                guestID = _guestManagement.GuestEkle(tcList[i].Text, nameList[i].Text, lastNameList[i].Text);

                _reservationGuestManagement.ReservationGuestAdd(reservationID, guestID);
            }
        }

        private void RoomReserved(Guid reservationID)
        {
            DateTime gun = dtGiris;
            int odaSayac;

            while (gun < dtCikis)
            {
                odaSayac = 0;

                while (odaSayac < seciliOdalar.Count)
                {
                    _roomReservationManagement.RoomReservationAdd(reservationID, seciliOdalar[odaSayac], gun);
                    odaSayac++;
                }

                gun = gun.AddDays(1);
            }
        }
    }
}