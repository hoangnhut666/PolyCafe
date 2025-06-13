using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Services_PolyCafe;
using DAL_Data_PolyCafe.Constants;
using DBUTIL_Utilities_PolyCafe;
using DTO_Models_PolyCafe;
using DBUTIL_Utilities_PolyCafe.ValidationHelper;

namespace GUI_UI_PolyCafe
{
    public partial class frmStaff : Form
    {
        private StaffServices StaffServices { get; set; }
        private StaffValidationHelper StaffValidationHelper { get; set; }

        public frmStaff()
        {
            StaffServices = new StaffServices();
            StaffValidationHelper = new StaffValidationHelper();
            InitializeComponent();
            SetupComponent(dgvStaff);
            LoadAllStaff();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            //Hide password fields by default
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }


        private void LoadAllStaff()
        {
            try
            {
                List<Staff> staff = StaffServices.GetAllStaff();
                if (staff != null && staff.Count > 0)
                {
                    dgvStaff.DataSource = staff;
                    dgvStaff.Columns["Password"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No staff data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvStaff.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while loading staff data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvStaff.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the staff information from the input fields
                Staff staff = new Staff
                {
                    Id = StaffServices.GenerateStaffId(),
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim() ? txtPassword.Text.Trim() : throw new ArgumentException("Passwords do not match"),
                    Role = rdoManager.Checked ? 1 : 0,
                    Status = chk_active.Checked ? 1 : 0, 
                };

                // Check if the staff information is valid
                if (!StaffValidationHelper.IsValidStaff(staff))
                {
                    MessageBox.Show(StaffValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add the staff to the database
                int result = StaffServices.AddStaff(staff);
                if (result > 0)
                {
                    MessageBox.Show("Staff added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaff();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStaffId.Text))
                {
                    MessageBox.Show("Please select a staff member to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the staff information from the input fields
                Staff staff = new Staff
                {
                    Id = txtStaffId.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim() ? txtPassword.Text.Trim() : throw new ArgumentException("Passwords do not match"),
                    Status = chk_active.Checked ? 1 : 0,
                    Role = rdoManager.Checked ? 1 : 0, 
                };

                //Prevent updating the role of a staff member
                Staff? selectedStaff = StaffServices.GetStaffByCriteria(StaffColumns.Id, staff.Id);
                if (selectedStaff != null && selectedStaff.Role != staff.Role)
                {
                    MessageBox.Show("You cannot change the role of a staff", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Check if the staff information is valid
                if (!StaffValidationHelper.IsValidStaff(staff))
                {
                    MessageBox.Show(StaffValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Update the staff in the database
                int result = StaffServices.UpdateStaff(staff);
                if (result > 0)
                {
                    MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaff();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a staff member is selected
            if (string.IsNullOrWhiteSpace(txtStaffId.Text))
            {
                MessageBox.Show("Please select a staff member to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the selected staff member is an admin or manager
            Staff? selectedStaff = StaffServices.GetStaffByCriteria(StaffColumns.Id,txtStaffId.Text);
            if (selectedStaff != null && selectedStaff.Role == 1 )
            {
                MessageBox.Show("You can not detele another admin or manager", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                // Get the staff ID from the input field
                string staffId = txtStaffId.Text.Trim();

                // Confirm deletion with the user
                var confirmResult = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return; 
                }

                // Delete the staff member from the database
                int result = StaffServices.DeleteStaff(staffId);
                if (result > 0)
                {
                    MessageBox.Show("Staff deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaff();
                    tabControl.SelectedTab = tabPageUpdate;
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadAllStaff();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStaff.SelectedRows[0];
                Staff selectedStaff = (Staff)selectedRow.DataBoundItem;

                // Fill the input fields with the selected staff's data
                txtStaffId.Text = selectedStaff.Id;
                txtFullName.Text = selectedStaff.FullName;
                txtEmail.Text = selectedStaff.Email;
                txtPassword.Text = selectedStaff.Password;
                txtConfirmPassword.Text = selectedStaff.Password;
                rdoManager.Checked = selectedStaff.Role == 1;
                rdoEmployee.Checked = selectedStaff.Role == 0;
                chk_active.Checked = selectedStaff.Status == 1;

                // Direct to the update section tab
                tabControl.SelectedTab = tabPageUpdate;
            }
            else
            {
                // Clear the input fields if no row is selected
                ClearInputFields();
            }
        }


        //Clear the input fields
        private void ClearInputFields()
        {
            txtStaffId.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            rdoManager.Checked = false;
        }


        private void chk_displayPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chk_displayPassword.Checked;
        }

        private void chk_displayConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !chk_displayConfirmPassword.Checked;
        }

        private void dgvStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStaff.Columns[e.ColumnIndex].Name == "Role" && e.Value != null)
            {
                int roleValue;
                if (int.TryParse(e.Value.ToString(), out roleValue))
                {
                    e.Value = roleValue == 1 ? "Quản lý" : "Nhân viên";
                    e.FormattingApplied = true;
                }
            }
            else if (dgvStaff.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                int statusValue;
                if (int.TryParse(e.Value.ToString(), out statusValue))
                {
                    e.Value = statusValue == 1 ? "Hoạt động" : "Không hoạt động";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}