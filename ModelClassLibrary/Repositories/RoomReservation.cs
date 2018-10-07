using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Repositories
{
    public class RoomReservation
    {
        public Guid ReservationID { get; set; }
        public int RoomID { get; set; }
        public DateTime ReservedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
