using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models_PolyCafe
{
    public class MembershipCard
    {
        public string? CardId { get; set; }
        public string? CardHolder { get; set; }
        public bool Status { get; set; } = true;
    }
}
