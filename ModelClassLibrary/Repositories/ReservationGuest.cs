using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Repositories
{
    public class ReservationGuest
    {
        public Guid ReservationID { get; set; }
        public Guid GuestID { get; set; }
    }
}
