using HotelReservation.DAL;
using ModelClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.BLL
{
    public class GuestManagementBLL
    {
        GuestManagement _management;

        public GuestManagementBLL()
        {
            _management = new GuestManagement();
        }

        public Guid GuestEkle(string tc, string isim, string soyisim)
        {
            return _management.GuestEkle(tc, isim, soyisim);
        }

        public Guest GuestList(Guid guestID)
        {
            return _management.GuestList(guestID);
        }
    }
}
