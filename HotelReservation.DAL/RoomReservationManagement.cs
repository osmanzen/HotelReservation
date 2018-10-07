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
    public class RoomReservationManagement : Connection
    {
        public List<int> BosOdalar(DateTime giris, DateTime cikis)
        {
            List<int> bosOdalar = new List<int>();

            string komut = "select * from fn_bosOdalar(@girisTarihi,@cikisTarihi)";
            SqlCommand cmd = new SqlCommand(komut, _conn);
            cmd.Parameters.AddWithValue("@girisTarihi", giris);
            cmd.Parameters.AddWithValue("@cikisTarihi", cikis);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bosOdalar.Add(Convert.ToInt32(dr[0]));
            }
            _conn.Close();

            return bosOdalar;
        }

        public void RoomReservationAdd(Guid reservationID, int roomID, DateTime reservetedDate)
        {
            SqlCommand cmd = new SqlCommand("sp_AddRoomReservation", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReservationID", reservationID);
            cmd.Parameters.AddWithValue("@RoomID", roomID);
            cmd.Parameters.AddWithValue("@ReservedDate", reservetedDate);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public List<int> ReservationRoomList(Reservation reservation)
        {
            List<int> roomsID = new List<int>();

            SqlCommand cmd = new SqlCommand("select distinct RoomID from RoomReservation where ReservationID = @reservationID", _conn);
            cmd.Parameters.AddWithValue("@reservationID", reservation.ReservationID);

            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                roomsID.Add((int)dr[0]);
            }
            _conn.Close();

            return roomsID;
        }

        public List<DateTime> MemberReservatedDate(Reservation reservation, int roomID)
        {
            List<DateTime> dates = new List<DateTime>();

            SqlCommand cmd = new SqlCommand("select MIN(ReservedDate),Max(ReservedDate) from RoomReservation where ReservationID=@reservationID and RoomID=@roomID", _conn);
            cmd.Parameters.AddWithValue("@ReservationID", reservation.ReservationID);
            cmd.Parameters.AddWithValue("@RoomID", roomID);

            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dates.Add((DateTime)dr[0]);
                dates.Add((DateTime)dr[1]);
            }
            _conn.Close();

            return dates;
        }
    }
}
