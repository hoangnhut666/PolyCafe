using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models_PolyCafe
{
    public class Staff
    {
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Role { get; set; } // 0 = Regular Employee, 1 = Admin/Manager
        public int Status { get; set; } //0 = Inactive/ Disable , 2= Active/Enable 
    }
}



