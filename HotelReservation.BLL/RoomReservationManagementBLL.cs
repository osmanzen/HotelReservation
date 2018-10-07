using HotelReservation.DAL;
using ModelClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.BLL
{
    public class RoomReservationManagementBLL
    {
        RoomReservationManagement _management;

        public RoomReservationManagementBLL()
        {
            _management = new RoomReservationManagement();
        }

        public List<int> BosOdalar(DateTime giris, DateTime cikis)
        {
            return _management.BosOdalar(giris, cikis);
        }

        public void RoomReservationAdd(Guid reservationID, int roomID, DateTime reservetedDate)
        {
            _management.RoomReservationAdd(reservationID, roomID, reservetedDate);
        }

        public List<int> ReservationRoomList(Reservation reservation)
        {
            return _management.ReservationRoomList(reservation);
        }

        public List<DateTime> MemberReservatedDate(Reservation reservation, int roomID)
        {
            return _management.MemberReservatedDate(reservation, roomID);
        }
    }
}
