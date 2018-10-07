using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DAL
{
    public class RoomManagement : Connection
    {
        public List<int> TumOdalar()
        {
            List<int> tumOdalar = new List<int>();

            string komut = "select RoomID from Room where IsActive=1";
            SqlCommand cmd = new SqlCommand(komut, _conn);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tumOdalar.Add(Convert.ToInt32(dr[0]));
            }
            _conn.Close();

            return tumOdalar;
        }
    }
}
