using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DAL
{
    public abstract class Connection
    {
        protected SqlConnection _conn;

        public Connection()
        {
            //_conn = new SqlConnection("Server = PC; Database = HotelSmurfs; UID = sa; Password = 123"); //KURS      
            _conn = new SqlConnection("Server=ZEN-PC;Database=HotelSmurfs;Trusted_Connection=True"); //OSMAN
            //_conn = new SqlConnection(@"Server=GULAY\sqlexpress;Database=HotelSmurfs;Trusted_Connection=True");//GULAY
            //_conn = new SqlConnection("Server = PC; Database = HotelSmurfs; UID = sa; Password = 123"); //KURS      
        }
    }
}
