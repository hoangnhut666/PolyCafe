using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models_PolyCafe
{
    public class RevenueByCategoryReport
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal TotalAmount { get; set; }
        public int QuantitySold { get; set; }
        public DateTime SaleDate { get; set; }
        public int NumberOfReceipts { get; set; }
        public int Status { get; set; }

    }
}



