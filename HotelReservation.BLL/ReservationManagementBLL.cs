using HotelReservation.DAL;
using ModelClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.BLL
{

    public class ReservationManagementBLL
    {
        ReservationManagement _management;
        public ReservationManagementBLL()
        {
            _management = new ReservationManagement();
        }

        public int ReservationAdd(Guid reservationID, Guid memberID, int reservationTypeID, decimal totalPrice)
        {
            return _management.ReservationAdd(reservationID, memberID, reservationTypeID, totalPrice);
        }

        public List<Reservation> ReservationList(Guid memberID, bool isActive)
        {
            return _management.ReservationList(memberID, isActive);
        }

        public void ReservationCancel(Guid reservationID)
        {
            _management.ReservationCancel(reservationID);
        }
    }
}