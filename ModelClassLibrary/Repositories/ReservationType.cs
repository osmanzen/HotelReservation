using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Repositories
{
    public class ReservationType
    {
        public int ReservationTypeID { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
