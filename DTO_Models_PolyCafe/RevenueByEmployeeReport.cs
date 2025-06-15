using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models_PolyCafe
{
    public class RevenueByEmployeeReport
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public decimal TotalAmount { get; set; }
        public int QuantitySold { get; set; }
        public DateTime SaleDate { get; set; }
        public int NumberOfReceipts { get; set; }
        public int Status { get; set; }
    }
}

