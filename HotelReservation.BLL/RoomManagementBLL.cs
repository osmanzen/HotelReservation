using HotelReservation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.BLL
{
    public class RoomManagementBLL
    {
        RoomManagement _management;

        public RoomManagementBLL()
        {
            _management = new RoomManagement();
        }

        public List<int> TumOdalar()
        {
            return _management.TumOdalar();
        }
    }
}
