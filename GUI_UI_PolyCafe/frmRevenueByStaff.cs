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
using DTO_Models_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class frmRevenueByStaff : Form
    {
        private ReportServices reportServices = new ReportServices();
        private StaffServices staffServices = new StaffServices();

        public frmRevenueByStaff()
        {
            InitializeComponent();
            SetupComponent(dgvReport);
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            //Set up DateTimePickers
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            //Set up Combobox
            cboEmployee.DisplayMember = "FullName";
            cboEmployee.ValueMember = "Id";
            cboEmployee.DataSource = staffServices.GetAllStaff();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Validate date range
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("End date must be after start date", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // From date and To date must be before current date
            if (dtpFromDate.Value > DateTime.Now || dtpToDate.Value > DateTime.Now)
            {
                MessageBox.Show("Date must be before current date", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get report data
                List<RevenueByEmployeeReport> reportData = reportServices.GetRevenueByEmployee(
                cboEmployee.SelectedValue?.ToString() ?? string.Empty,
                dtpFromDate.Value.Date,
                dtpToDate.Value.Date);

            dgvReport.DataSource = reportData;
            // Check if there is no data
            if (reportData.Count == 0)
            {
                MessageBox.Show("No data found for the selected criteria.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReport.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                int statusValue;
                if (int.TryParse(e.Value.ToString(), out statusValue))
                {
                    e.Value = statusValue == 1 ? "Đang hoạt động" : "Ngừng hoạt động";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
