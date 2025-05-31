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
using DBUTIL_Utilities_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class frmChangePassword : Form
    {

        private readonly StaffRepository _staffRepo = new StaffRepository();
        public frmChangePassword()
        {
            InitializeComponent();
            SetupComponent();
            LoadStaffInfo();
        }


        private void SetupComponent()
        {
            ClientSize = new Size(2000, 1300);
            StartPosition = FormStartPosition.CenterScreen;
            txtCurrentPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }


        private void LoadStaffInfo()
        {
            if (AuthUtil.IsLoggedIn())
            {
                txtStaffId.Text = AuthUtil.CurrentUser.Id;
                txtFullName.Text = AuthUtil.CurrentUser.FullName;
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLoggedIn())
            {
                txtStaffId.Text = AuthUtil.CurrentUser.Id;
                txtFullName.Text = AuthUtil.CurrentUser.FullName;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string? staffId = AuthUtil.CurrentUser.Id;

            // Verify current password
            if (AuthUtil.CurrentUser.Password != currentPassword)
            {
                MessageBox.Show("Current password is incorrect", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update password
            if (_staffRepo.UpdatePassword(staffId, newPassword))
            {
                MessageBox.Show("Password changed successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                AuthUtil.ChangePassword(newPassword);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void chkShowCurrentPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = !chkShowOldPassword.Checked;
        }

        private void chkShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkShowNewPassword.Checked;
        }

        private void chkShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !chkShowConfirmPassword.Checked;
        }



        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                MessageBox.Show("Please enter current password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter new password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New password and confirmation don't match", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
