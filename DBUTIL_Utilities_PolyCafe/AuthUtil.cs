using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models_PolyCafe;

namespace DBUTIL_Utilities_PolyCafe
{
    public static class AuthUtil
    {
        private static Staff _currentUser;

        public static Staff CurrentUser
        {
            get => _currentUser;
            private set => _currentUser = value;
        }

        public static bool IsLoggedIn() => _currentUser != null;

        public static bool IsManager() => IsLoggedIn() && _currentUser.Role == 1;

        public static void Login(Staff staff)
        {
            CurrentUser = staff;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static void ChangePassword(string newPassword)
        {
            if (IsLoggedIn())
            {
                CurrentUser.Password = newPassword;
            }
        }
    }
}
