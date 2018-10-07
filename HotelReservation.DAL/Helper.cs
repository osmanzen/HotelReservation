using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DAL
{
    public class Helper
    {
        public static string ConnectionString()
        {
            return "Server=.;Database=NORTHWND;Trusted_Connection=true;";
        }
    }
}

