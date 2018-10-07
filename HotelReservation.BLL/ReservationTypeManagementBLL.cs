using HotelReservation.DAL;
using ModelClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.BLL
{
    public class ReservationTypeManagementBLL
    {
        ReservationTypeManagement _management;

        public ReservationTypeManagementBLL()
        {
            _management = new ReservationTypeManagement();
        }

        public ReservationType ReservationTypeDondur(int typeID)
        {
            return _management.ReservationTypeDondur(typeID);
        }
    }
}
