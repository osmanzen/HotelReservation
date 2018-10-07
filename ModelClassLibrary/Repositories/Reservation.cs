using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Repositories
{
    public class Reservation
    {
        public Guid ReservationID { get; set; }
        public Guid MemberID { get; set; }
        public DateTime ReservationDate { get; set; }
        public int ReservationTypeID { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
