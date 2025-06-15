using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models_PolyCafe;

namespace DBUTIL_Utilities_PolyCafe.ValidationHelper
{
    public class InvoiceValidationHelper
    {
        public string ErrorMessage { get; set; } = string.Empty;

        public bool IsValidateInvoice(Invoice invoice)
        {
            if (string.IsNullOrEmpty(invoice.CardId))
            {
                ErrorMessage = "Invoice CardID cannot be null or empty.";
                return false;
            }


            if (string.IsNullOrEmpty(invoice.StaffId))
            {
                ErrorMessage = "Invoice StaffID cannot be null or empty.";
                return false;
            }


            return true;
        }
    }
}
