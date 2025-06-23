using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models_PolyCafe;
using System.Text.RegularExpressions;

namespace DBUTIL_Utilities_PolyCafe.ValidationHelper
{
    public class StaffValidationHelper
    {
        public string ErrorMessage { get; set; } = string.Empty;

        public bool IsValidStaff(Staff staff)
        {
            // Check if the staff ID is null or empty
            if (string.IsNullOrEmpty(staff.Id))
            {
                ErrorMessage = "Staff ID cannot be null or empty.";
                return false;
            }

            // Check if the staff full name is null or empty
            if (string.IsNullOrEmpty(staff.FullName))
            {
                ErrorMessage = "Staff full name cannot be null or empty.";
                return false;
            }

            // Check if the staff email is null or empty
            if (string.IsNullOrEmpty(staff.Email))
            {
                ErrorMessage = "Staff email cannot be null or empty.";
                return false;
            }

            // Check if the staff password is null or empty
            if (string.IsNullOrEmpty(staff.Password))
            {
                ErrorMessage = "Staff password cannot be null or empty.";
                return false;
            }

            //Check if the email is in a valid format with a simple regex
            if (!Regex.IsMatch(staff.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ErrorMessage = "Staff email is not in a valid format.";
                return false;
            }


            return true;
        }
    }
}
