using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUTIL_Utilities_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            SetupComponent(dataGridView: null);
            CheckAuthorization();
            InitializeUI();
        }

        private void SetupComponent(DataGridView? dataGridView)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeUI()
        {
            //this.Text = "PolyCafe - Main Menu";
            //this.WindowState = FormWindowState.Maximized;
            timerClock.Start();
            timerClock.Tick += TimerClock_Tick;

            // Configure menu items based on user role
            itmStaffManagement.Visible = AuthUtil.IsManager();
            btnStaffManagement.Visible = AuthUtil.IsManager();

            EmbedFormIntoPanel(new frmAbout());
        }

        private void CheckAuthorization()
        {
            if (!AuthUtil.IsLoggedIn())
            {
                ShowLogin();
            }
            else
            {
                UpdateUserInfo();
            }
        }

        private void ShowLogin()
        {
            this.Hide();

            using (var frmLogin = new Login())
            {
                if (frmLogin.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            this.Show();
            UpdateUserInfo();
        }

        private void UpdateUserInfo()
        {
            lblAccount.Text = $"Welcome: {AuthUtil.CurrentUser.FullName}";
            lblRole.Text = AuthUtil.IsManager() ? "Role: Admin" : "Role: Staff";
        }


        //Embed another form into the panel of main screen
        private void EmbedFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMainContainer.Controls.Clear();
            pnlMainContainer.Controls.Add(form);
            form.Show();
        }


        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            // Check if the user is authorized to access this feature
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and show the staff management form
            var staffManagementForm = new frmStaff();
            EmbedFormIntoPanel(staffManagementForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Ask for confirmation before exiting the application
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void itmStaffManagement_Click(object sender, EventArgs e)
        {
            // Check if the user is authorized to access this feature
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and show the staff management form
            var staffManagementForm = new frmStaff();
            EmbedFormIntoPanel(staffManagementForm);
        }

        private void itmProductCategoriesManagement_Click(object sender, EventArgs e)
        {
            // Check if the user is authorized to access this feature
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and show the product categories management form
            var productCategoriesForm = new frmProductCategories();
            EmbedFormIntoPanel(productCategoriesForm);
        }

        private void itmProductManagement_Click(object sender, EventArgs e)
        {
            // Check if the user is authorized to access this feature
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and show the product management form
            var productManagementForm = new frmProduct();
            EmbedFormIntoPanel(productManagementForm);
        }

        private void itmInvoiceManagement_Click(object sender, EventArgs e)
        {
            // Pass current user ID if not manager, otherwise null
            string? userId = AuthUtil.IsManager() ? null : AuthUtil.CurrentUser.Id;

            // Create and show the invoice management form, passing userId
            var invoiceManagementForm = new frmInvoiceManagement(userId);
            EmbedFormIntoPanel(invoiceManagementForm);
        }

        private void itmChangePassword_Click(object sender, EventArgs e)
        {
            // Check if the user is authorized to access this feature
            if (!AuthUtil.IsLoggedIn())
            {
                MessageBox.Show("You must be logged in to change your password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and show the change password form
            var changePasswordForm = new frmChangePassword();
            changePasswordForm.ShowDialog();
        }

        private void itmMembershipCardManagement_Click(object sender, EventArgs e)
        {
            // Check if the user is authorized to access this feature
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and show the membership card management form
            var membershipCardManagementForm = new frmMembershipCard();
            EmbedFormIntoPanel(membershipCardManagementForm);
        }

        private void itmHelp_Click(object sender, EventArgs e)
        {
            var helpForm = new frmHelp();
            EmbedFormIntoPanel(helpForm);
        }

        private void itmAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new frmAbout();
            EmbedFormIntoPanel(aboutForm);
        }

        private void itmExit_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before exiting the application
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
