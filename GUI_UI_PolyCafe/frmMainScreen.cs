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
            InitializeUI();
        }


        private void SetupComponent(DataGridView? dataGridView)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeUI()
        {
            timerClock.Start();
            timerClock.Tick += TimerClock_Tick;

            EmbedFormIntoPanel(new frmAbout());
        }


        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            UpdateUserInfo();
        }

        private void UpdateUserInfo()
        {
            if (AuthUtil.CurrentUser != null)
            {
                lblAccount.Text = $"Welcome: {AuthUtil.CurrentUser.FullName}";
                lblRole.Text = AuthUtil.IsManager() ? "Role: Admin" : "Role: Staff";
            }
        }



        //Embed another form into the panel of main screen
        private void EmbedFormIntoPanel(Form form)
        {
            // Dispose the old form if present
            if (pnlMainContainer.Controls.Count > 0)
            {
                var oldForm = pnlMainContainer.Controls[0] as Form;
                oldForm?.Dispose();
            }

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
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var staffManagementForm = new frmStaff();
            EmbedFormIntoPanel(staffManagementForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void itmStaffManagement_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var staffManagementForm = new frmStaff();
            EmbedFormIntoPanel(staffManagementForm);
        }

        private void itmProductCategoriesManagement_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productCategoriesForm = new frmProductCategories();
            EmbedFormIntoPanel(productCategoriesForm);
        }

        private void itmProductManagement_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (!AuthUtil.IsLoggedIn())
            {
                MessageBox.Show("You must be logged in to change your password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var changePasswordForm = new frmChangePassword();
            changePasswordForm.ShowDialog();

        }

        private void itmMembershipCardManagement_Click(object sender, EventArgs e)
        {
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
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void itmRevenueByCategory_Click(object sender, EventArgs e)
        {
            //Check if the user is a manager
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and show the revenue by category form
            var revenueByCategoryForm = new frmRevenueByCategory();
            EmbedFormIntoPanel(revenueByCategoryForm);
        }

        private void itmRevenueByStaff_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var revenueByStaffForm = new frmRevenueByStaff();
            EmbedFormIntoPanel(revenueByStaffForm);
        }

        private void btnProductCategoriesManagemet_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productCategoriesForm = new frmProductCategories();
            EmbedFormIntoPanel(productCategoriesForm);
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productManagementForm = new frmProduct();
            EmbedFormIntoPanel(productManagementForm);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new frmAbout();
            EmbedFormIntoPanel(aboutForm);
        }


    }
}
