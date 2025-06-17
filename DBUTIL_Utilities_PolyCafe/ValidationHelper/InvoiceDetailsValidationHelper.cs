using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using DTO_Models_PolyCafe;

namespace DBUTIL_Utilities_PolyCafe.ValidationHelper
{
    public class InvoiceDetailsValidationHelper
    {
        public string ErrorMessage { get; set; } = string.Empty;

        public bool IsValidInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            //Check if Quantity is positive integer
            if (invoiceDetail.Quantity <= 0)
            {
                ErrorMessage = "Quantity must be a positive integer.";
                return false;
            }

            //Check if UnitPrice is a positive decimal
            if (invoiceDetail.UnitPrice <= 0)
            {
                ErrorMessage = "Unit Price must be a positive decimal.";
                return false;
            }


            //Check if details contains valid ProductId
            if (string.IsNullOrEmpty(invoiceDetail.ProductId))
            {
                ErrorMessage = "Product cannot be null or empty.";
                return false;
            }


            return true;
        }

    }
}



//public int Id { get; set; }
//public string? InvoiceId { get; set; }
//public string? ProductId { get; set; }
//public int Quantity { get; set; }
//public decimal UnitPrice { get; set; }