using ModelClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DAL
{
    public class ReservationGuestManagement : Connection

    {
        public int ReservationGuestAdd(Guid reservationID, Guid guestID)
        {
            int sonuc;

            SqlCommand cmd = new SqlCommand("sp_AddReservationGuest", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReservationID", reservationID);
            cmd.Parameters.AddWithValue("@GuestID", guestID);

            _conn.Open();
            sonuc = cmd.ExecuteNonQuery();
            _conn.Close();

            return sonuc;
        }

        public List<ReservationGuest> ReservationGuestList(Guid reservationID)
        {
            ReservationGuest rsGuest;
            List<ReservationGuest> rsGuestList = new List<ReservationGuest>();

            SqlCommand cmd = new SqlCommand("select*from ReservationGuest where ReservationID=@reservationID", _conn);
            cmd.Parameters.AddWithValue("@reservationID", reservationID);

            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rsGuest = new ReservationGuest();
                rsGuest.ReservationID = (Guid)dr[0];
                rsGuest.GuestID = (Guid)dr[1];
                rsGuestList.Add(rsGuest);
            }
            _conn.Close();
            rsGuestList.Reverse();
            return rsGuestList;
        }
    }
}
