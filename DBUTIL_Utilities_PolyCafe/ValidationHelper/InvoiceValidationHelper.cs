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
                ErrorMessage = "Tên khách hàng không được để trống.";
                return false;
            }


            if (string.IsNullOrEmpty(invoice.StaffId))
            {
                ErrorMessage = "Tên nhân viên không được để trống.";
                return false;
            }


            if (invoice.Date > DateTime.Now)
            {
                ErrorMessage = "Ngày tạo hóa đơn không thể ở tương lai.";
                return false;
            }


            return true;
        }
    }
}
