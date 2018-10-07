using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelClassLibrary.Repositories
{
    public class Guest
    {
        public Guid GuestID { get; set; }
        public string IdentityNo { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool  IsActive { get; set; }
    }
}
