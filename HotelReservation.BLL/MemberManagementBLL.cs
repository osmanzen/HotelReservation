using HotelReservation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.BLL
{

    public class MemberManagementBLL
    {
        MemberManagement _management;

        public MemberManagementBLL()
        {
            _management = new MemberManagement();
        }

        public string MemberID_Dondur(string identity, string password)
        {
            return _management.MemberID_Dondur(identity, password);
        }

        public bool MemberEkle(string kimlikNo, string firstName, string lastName, string email, string phone, string password) //submitRegister_Click tetiklenince çalışacak. 
        {
            return _management.MemberEkle(kimlikNo, firstName, lastName, email, phone, password);
        }




    }
}
