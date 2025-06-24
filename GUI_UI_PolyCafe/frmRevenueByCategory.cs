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
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_UI_PolyCafe
{
    public partial class frmRevenueByCategory : Form
    {
        private ReportServices reportServices = new ReportServices();
        private ProductCategoryServices productCategoryServices = new ProductCategoryServices();

        public frmRevenueByCategory()
        {
            InitializeComponent();
            SetupComponent(dgvReport);
        }

        private void SetupComponent(DataGridView dataGridView)
        {
            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";


            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            //Setup combobox
            cboCategory.DataSource = productCategoryServices.GetAllProductCategories();
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
            cboCategory.SelectedIndex = -1;
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
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
                List<RevenueByCategoryReport> reportData = reportServices.GetRevenueByCategory(
                    cboCategory.SelectedValue?.ToString() ?? string.Empty,
                    dtpFromDate.Value.Date,
                    dtpToDate.Value.Date);

                dgvReport.DataSource = reportData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvReport.Columns["ProductId"].HeaderText = "Mã Sản Phẩm";
            dgvReport.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
            dgvReport.Columns["TotalAmount"].HeaderText = "Tổng Doanh Thu";
            dgvReport.Columns["QuantitySold"].HeaderText = "Số Lượng Bán";
            dgvReport.Columns["SaleDate"].HeaderText = "Ngày Bán";
            dgvReport.Columns["NumberOfReceipts"].HeaderText = "Số Lượng Phiếu";
            dgvReport.Columns["Status"].HeaderText = "Trạng Thái";
        }

        private void dgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}


