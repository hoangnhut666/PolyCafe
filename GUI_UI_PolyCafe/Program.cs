using DBUTIL_Utilities_PolyCafe;
using GUI_UI_PolyCafe;

namespace GUI_UI_PolyCafe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Show the main(home) screen first
            //using (var mainForm = new frmMainScreen())
            //{
            //    // Show the welcome screen as a dialog
            //    using (var frmWelcome = new Welcome())
            //    {
            //        frmWelcome.ShowDialog();
            //    }

            //    // Show the login screen as a dialog
            //    using (var frmLogin = new Login())
            //    {
            //        if (frmLogin.ShowDialog() == DialogResult.OK)
            //        {
            //            Application.Run(mainForm);
            //        }
            //        else
            //        {
            //            Application.Exit();
            //        }
            //    }
            //}

            Application.Run(new frmInvoiceManagement());
        }
    }
}




























//// Show splash screen first
//using (var frmWelcome = new Welcome())
//{
//    frmWelcome.ShowDialog();
//}

//// Then show login form
//using (var frmLogin = new Login())
//{
//    if (frmLogin.ShowDialog() == DialogResult.OK)
//    {
//        // If login successful, run main application
//        Application.Run(new frmMainScreen());
//    }
//    else
//    {
//        // If login cancelled, exit application
//        Application.Exit();
//    }
//}



//// Show splash screen first
//using (var frmWelcome = new Welcome())
//{
//    frmWelcome.ShowDialog();
//}

//// Then show login form
//using (var frmLogin = new Login())
//{
//    if (frmLogin.ShowDialog() == DialogResult.OK)
//    {
//        // If login successful, run main application
//        Application.Run(new frmMainScreen());
//    }
//    else
//    {
//        // If login cancelled, exit application
//        Application.Exit();
//    }
//}


//static void Main()
//{
//    // To customize application configuration such as set high DPI settings or default font,
//    // see https://aka.ms/applicationconfiguration.
//    ApplicationConfiguration.Initialize();

//    // Show splash screen first
//    using (var frmWelcome = new Welcome())
//    {
//        frmWelcome.ShowDialog();
//    }

//    // Then show login form
//    using (var frmLogin = new Login())
//    {
//        if (frmLogin.ShowDialog() == DialogResult.OK)
//        {
//            // If login successful, run main application
//            Application.Run(new frmMainScreen());
//        }
//        else
//        {
//            // If login cancelled, exit application
//            Application.Exit();
//        }
//    }

//}



//// Show splash screen first
//using (var frmWelcome = new Welcome())
//{
//    frmWelcome.ShowDialog();
//}

//// Then show login form
//using (var frmLogin = new Login())
//{
//    if (frmLogin.ShowDialog() == DialogResult.OK)
//    {
//        // If login successful, run main application
//        Application.Run(new frmMainScreen());
//    }
//    else
//    {
//        // If login cancelled, exit application
//        Application.Exit();
//    }
//}