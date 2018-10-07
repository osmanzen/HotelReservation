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
    public class ReservationTypeManagement:Connection
    {
        public ReservationType ReservationTypeDondur(int typeID)
        {
            ReservationType rt = new ReservationType();
            SqlCommand cmd = new SqlCommand("select * from ReservationType where ReservationTypeID=@ID", _conn);

            cmd.Parameters.AddWithValue("@ID", typeID);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rt.ReservationTypeID = Convert.ToInt32(dr[0]);
                rt.TypeName = dr[1].ToString();
                rt.Description = dr[2].ToString();
                rt.Price = Convert.ToDecimal(dr[3]);
            }
            _conn.Close();
            return rt;
        }
    }
}
