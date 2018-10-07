using HotelReservation.DAL;
using ModelClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.BLL
{
    public class ReservationGuestManagementBLL
    {
        ReservationGuestManagement _management;

        public ReservationGuestManagementBLL()
        {
            _management = new ReservationGuestManagement();
        }

        public int ReservationGuestAdd(Guid reservationID, Guid guestID)
        {
            return _management.ReservationGuestAdd(reservationID, guestID);
        }

        public List<ReservationGuest> ReservationGuestList(Guid reservationID)
        {
            return _management.ReservationGuestList(reservationID);
        }
    }
}
