using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Repositories
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
