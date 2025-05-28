using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models_PolyCafe
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public string? InvoiceId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}


