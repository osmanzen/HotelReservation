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
    public class ReservationManagement:Connection
    {
        public int ReservationAdd(Guid reservationID, Guid memberID, int reservationTypeID, decimal totalPrice)
        {
            int sonuc;

            SqlCommand cmd = new SqlCommand("sp_AddReservation", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Reservation_ID", reservationID);
            cmd.Parameters.AddWithValue("@Member_ID", memberID);
            cmd.Parameters.AddWithValue("@Reservation_Date", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@Reservation_Type_ID", reservationTypeID);
            cmd.Parameters.AddWithValue("@Total_Price", totalPrice);
            _conn.Open();
            sonuc = cmd.ExecuteNonQuery();
            _conn.Close();

            return sonuc;
        }


        public List<Reservation> ReservationList(Guid memberID,bool isActive)
        {
            Reservation rs;
            List<Reservation> rsvList = new List<Reservation>();

            SqlCommand cmd = new SqlCommand("select*from Reservation where MemberID=@memberID and IsActive=@isActive order by ReservationDate desc",_conn);
            cmd.Parameters.AddWithValue("@memberID",memberID);
            cmd.Parameters.AddWithValue("@isActive",isActive);

            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                rs=new Reservation();
                rs.ReservationID =(Guid)dr[0];
                rs.MemberID =(Guid)dr[1];
                rs.ReservationDate =(DateTime)dr[2];
                rs.ReservationTypeID = (int)dr[3];
                rs.TotalPrice = (decimal)dr[4];
                rs.IsActive = (bool)dr[5];

                rsvList.Add(rs);
            }
            _conn.Close();

            return rsvList;
        }

        public void ReservationCancel(Guid reservationID)
        {
            SqlCommand cmd = new SqlCommand("update Reservation set IsActive=0 where ReservationID=@reservationID",_conn);
            cmd.Parameters.AddWithValue("@reservationID",reservationID);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
