using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelClassLibrary.Repositories;

namespace HotelReservation.DAL
{
    public class GuestManagement:Connection
    {
        public Guid GuestEkle(string tc, string isim, string soyisim)
        {
            Guid GuestID;

            SqlCommand cmd = new SqlCommand("sp_AddGuest",_conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TC", tc);
            cmd.Parameters.AddWithValue("@isim", isim);
            cmd.Parameters.AddWithValue("@soyisim", soyisim);


            SqlParameter outputID = new SqlParameter();
            outputID.ParameterName = "@ID";
            outputID.SqlDbType = SqlDbType.UniqueIdentifier;
            outputID.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(outputID);

            _conn.Open();
            cmd.ExecuteNonQuery();
            GuestID = (Guid)outputID.Value;
            _conn.Close();

            return GuestID;
        }

        public Guest GuestList(Guid guestID)
        {
            Guest guest = new Guest();

            SqlCommand cmd = new SqlCommand("select*from Guest where GuestID=@guestID", _conn);
            cmd.Parameters.AddWithValue("@guestID", guestID);

            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                guest.GuestID = (Guid)dr[0];
                guest.IdentityNo = (string)dr[1];
                guest.Firstname = (string)dr[2];
                guest.Lastname = (string)dr[3];
                guest.IsActive = (bool)dr[4];
            }
            _conn.Close();

            return guest;
        }

    }
}
