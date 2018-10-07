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
    public partial class memberinfo : System.Web.UI.Page
    {
        ReservationManagementBLL _reservationManagement = new ReservationManagementBLL();
        RoomReservationManagementBLL _roomReservationManagement = new RoomReservationManagementBLL();
        ReservationGuestManagementBLL _reservationGuestManagement = new ReservationGuestManagementBLL();
        GuestManagementBLL _guestManagement = new GuestManagementBLL();
        ReservationTypeManagementBLL _reservationTypeManagement = new ReservationTypeManagementBLL();

        List<Reservation> reservationList;
        List<int> roomNumbers;
        List<DateTime> reservatedDate;
        List<ReservationGuest> reservationGuestID;
        List<Guest> guests;
        ReservationType reservationType;
        Table tbReservationDetails;
        TableRow row;
        TableCell cell;
        Literal lt;
        Button btn;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Guid memberID = new Guid(Session["user"].ToString());

                reservationList = _reservationManagement.ReservationList(memberID, true);

                foreach (Reservation reservation in reservationList)
                {
                    roomNumbers = _roomReservationManagement.ReservationRoomList(reservation);
                    reservatedDate = _roomReservationManagement.MemberReservatedDate(reservation, roomNumbers[0]);
                    reservationGuestID = _reservationGuestManagement.ReservationGuestList(reservation.ReservationID);

                    guests = new List<Guest>();
                    foreach (ReservationGuest item in reservationGuestID)
                    {
                        guests.Add(_guestManagement.GuestList(item.GuestID));
                    }
                    reservationType = _reservationTypeManagement.ReservationTypeDondur(reservation.ReservationTypeID);


                    tbReservationDetails = new Table();
                    tbReservationDetails.CssClass = "table table-hover table-bordered";
                    tbReservationDetails.Style.Add("margin-top", "5%");
                    tbReservationDetails.Style.Add("margin-bottom", "0");

                    row = new TableRow();
                    cell = new TableCell();
                    cell.CssClass = "success";
                    lt = new Literal();
                    lt.Text = "Rezervasyon Tarihi: " + reservation.ReservationDate.ToShortDateString();
                    cell.Controls.Add(lt);
                    row.Controls.Add(cell);

                    cell = new TableCell();
                    cell.CssClass = "success";
                    lt = new Literal();
                    lt.Text = "Giriş Tarihi: " + reservatedDate[0].ToShortDateString();
                    cell.Controls.Add(lt);
                    row.Controls.Add(cell);

                    cell = new TableCell();
                    cell.CssClass = "success";
                    lt = new Literal();
                    lt.Text = "Çıkış Tarihi: " + (reservatedDate[1]).AddDays(1).ToShortDateString();
                    cell.Controls.Add(lt);
                    row.Controls.Add(cell);

                    cell = new TableCell();
                    cell.CssClass = "success";
                    lt = new Literal();
                    lt.Text = "Fatura Tutarı: " + string.Format("{0:0,0.00}", reservation.TotalPrice) + " TL";
                    cell.Controls.Add(lt);
                    row.Controls.Add(cell);

                    tbReservationDetails.Controls.Add(row);


                    int guestCounter = 0;

                    for (int i = 0; i < roomNumbers.Count; i++)
                    {
                        row = new TableRow();

                        cell = new TableCell();
                        cell.CssClass = "info";
                        lt = new Literal();
                        lt.Text = (i + 1) + ". Oda = " + roomNumbers[i];
                        cell.Controls.Add(lt);
                        row.Controls.Add(cell);

                        if ((guests.Count - guestCounter) / 3 >= 1)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                cell = new TableCell();
                                cell.CssClass = "warning";
                                lt = new Literal();
                                lt.Text = guests[guestCounter].Firstname + " " + guests[guestCounter].Lastname;
                                cell.Controls.Add(lt);
                                row.Controls.Add(cell);
                                guestCounter++;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < guests.Count % 3; j++)
                            {
                                cell = new TableCell();
                                cell.CssClass = "warning";
                                lt = new Literal();
                                lt.Text = guests[guestCounter].Firstname + " " + guests[guestCounter].Lastname;
                                cell.Controls.Add(lt);
                                row.Controls.Add(cell);
                                guestCounter++;
                            }
                            for (int j = 0; j < 3 - (guests.Count % 3); j++)
                            {
                                cell = new TableCell();
                                cell.CssClass = "warning";
                                row.Controls.Add(cell);
                            }
                        }

                        tbReservationDetails.Controls.Add(row);
                    }
                    pnlReservations.Controls.Add(tbReservationDetails);                    
                    btn = new Button();
                    btn.UseSubmitBehavior = false;
                    btn.Click+=ResCancel_Click;
                    btn.Text = "Rezervasyon İptal";
                    btn.CssClass = "btn btn-danger btn-sm btn-block";
                    btn.Style.Add("color","white");
                    btn.CommandName = reservation.ReservationID.ToString();
                    pnlReservations.Controls.Add(btn);
                }
            }
        }

        private void ResCancel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Guid rezID = new Guid(btn.CommandName);

            _reservationManagement.ReservationCancel(rezID);

            Response.Redirect(Request.RawUrl);
        }
    }
}
