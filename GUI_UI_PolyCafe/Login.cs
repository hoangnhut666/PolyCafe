using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Data_PolyCafe;
using DTO_Models_PolyCafe;
using DBUTIL_Utilities_PolyCafe;
using BLL_Services_PolyCafe;
using DAL_Data_PolyCafe.Constants;

namespace GUI_UI_PolyCafe
{
    public partial class Login : Form
    {
        private readonly StaffServices staffServices = new StaffServices();

        public Login()
        {
            InitializeComponent();
            SetUpComponents();
        }

        private void SetUpComponents()
        {
            txtPassWord.UseSystemPasswordChar = true;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffId = txtUserName.Text.Trim();
            string password = txtPassWord.Text;

            if (string.IsNullOrEmpty(staffId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both staff ID and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Staff? staff = staffServices.GetStaffByCriteria(StaffColumns.Id, staffId);

                if (staff == null || staff.Password != password)
                {
                    MessageBox.Show("Invalid staff ID or password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AuthUtil.Login(staff);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExitLoginPage_Click(object sender, EventArgs e)
        {
            //Ask the user if they want to exit the application
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
