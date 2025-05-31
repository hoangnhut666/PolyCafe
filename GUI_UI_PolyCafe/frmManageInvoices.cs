using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Models_PolyCafe;
using BLL_Services_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class frmManageInvoices : Form
    {
        private readonly InvoiceServices invoiceServices;
        private readonly InvoiceDetailsServices invoiceDetailsServices;
        private readonly MembershipCardServices membershipCardServices;
        private readonly StaffServices staffServices;
        private readonly ProductServices productServices;

        public frmManageInvoices()
        {
            invoiceServices = new InvoiceServices();
            invoiceDetailsServices = new InvoiceDetailsServices();
            membershipCardServices = new MembershipCardServices();
            staffServices = new StaffServices();
            productServices = new ProductServices();
            InitializeComponent();
            SetupComponent();
            LoadAllInvoices();
            LoadAllInvoiceDetails();
        }


        private void SetupComponent()
        {
            // Set the DataGridView properties
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.AutoGenerateColumns = true;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceDetails.AutoGenerateColumns = true;
            dgvInvoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;


            //Set up ComboBox for Products
            cboProductName.DataSource = productServices.GetAllProducts();
            cboProductName.DisplayMember = "ProductName"; // Assuming Product has a Name property
            cboProductName.ValueMember = "ProductId"; // Assuming Product has an Id property
            cboProductName.SelectedIndex = -1; // No selection by default


            //Set up ComboBox for Membership Cards
            cboCardHolder.DataSource = membershipCardServices.GetAllMembershipCards();
            cboCardHolder.DisplayMember = "CardHolder"; // Assuming MembershipCard has a CardHolder property
            cboCardHolder.ValueMember = "CardId"; // Assuming MembershipCard has a CardId property
            cboCardHolder.SelectedIndex = -1; // No selection by default


            //Set up ComboBox for Staff
            cboStaff.DataSource = staffServices.GetAllStaff();
            cboStaff.DisplayMember = "FullName"; // Assuming Staff has a Name property
            cboStaff.ValueMember = "Id"; // Assuming Staff has an Id property
            cboStaff.SelectedIndex = -1; // No selection by default
        }

        //Load all invoices
        private void LoadAllInvoices()
        {
            try
            {
                var invoices = invoiceServices.GetAllInvoices();
                if (invoices != null && invoices.Count > 0)
                {
                    dgvInvoices.DataSource = invoices;
                }
                else
                {
                    MessageBox.Show("No invoices found.");
                    dgvInvoices.DataSource = null;
                }
            }
            catch (Exception e )
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvInvoices.DataSource = null;
            }
        }


        //Load all invoice details
        private void LoadAllInvoiceDetails()
        {
            try
            {
                var invoiceDetails = invoiceDetailsServices.GetAllInvoiceDetails();
                if (invoiceDetails != null && invoiceDetails.Count > 0)
                {
                    dgvInvoiceDetails.DataSource = invoiceDetails;
                }
                else
                {
                    MessageBox.Show("No invoice details found.");
                    dgvInvoiceDetails.DataSource = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Get invoice from the form fields
        private Invoice GetInvoiceFromForm()
        {
            return new Invoice
            {
                Id = invoiceServices.GenerateInvoiceId(),
                CardId = cboCardHolder.SelectedValue?.ToString() ?? string.Empty,
                StaffId = cboStaff.SelectedValue?.ToString() ?? string.Empty,
                Date = dtpDate.Value,
                Status = rdoPaid.Checked
            };
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ensure that the selected values are not null before accessing them
            if (!IsValidInvoice())
            {
                return;
            }

            // Get a new invoice object with the data from the form fields
            Invoice invoice = new Invoice
            {
                Id = invoiceServices.GenerateInvoiceId(),
                CardId = cboCardHolder.SelectedValue?.ToString() ?? string.Empty,
                StaffId = cboStaff.SelectedValue?.ToString() ?? string.Empty,
                Date = dtpDate.Value,
                Status = rdoPaid.Checked
            };


            // Add the invoice to the database
            int result = invoiceServices.AddInvoice(invoice);
            if (result > 0)
            {
                MessageBox.Show("Invoice added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInvoices.DataSource = invoiceServices.GetAllInvoices();
                ClearInvoice();
            }
            else
            {
                MessageBox.Show("Failed to add invoice. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure that the selected values are not null before accessing them
            if (!IsValidInvoice())
            {
                return;
            }

            // Get the selected invoice ID
            string invoiceId = txtInvoiceId.Text.Trim();
            if (string.IsNullOrEmpty(invoiceId))
            {
                MessageBox.Show("Please select an invoice to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the updated invoice object with the data from the form fields
            Invoice invoice = new Invoice
            {
                Id = invoiceId,
                CardId = cboCardHolder.SelectedValue?.ToString(),
                StaffId = cboStaff.SelectedValue?.ToString(),
                Date = dtpDate.Value,
                Status = rdoPaid.Checked
            };

            // Update the invoice in the database
            int result = invoiceServices.UpdateInvoice(invoice);
            if (result > 0)
            {
                MessageBox.Show("Invoice updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInvoices.DataSource = invoiceServices.GetAllInvoices();
                ClearInvoice(); // Clear the form fields after updating
            }
            else
            {
                MessageBox.Show("Failed to update invoice. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure that an invoice is selected
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an invoice to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected invoice ID
            string invoiceId = txtInvoiceId.Text.Trim();
            if (string.IsNullOrEmpty(invoiceId))
            {
                MessageBox.Show("Please select a valid invoice to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this invoice?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the invoice from the database
                int deleteResult = invoiceServices.DeleteInvoice(invoiceId);
                if (deleteResult > 0)
                {
                    MessageBox.Show("Invoice deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvInvoices.DataSource = invoiceServices.GetAllInvoices();
                    ClearInvoice(); // Clear the form fields after deletion
                }
                else
                {
                    MessageBox.Show("Failed to delete invoice. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllInvoices();
            LoadAllInvoiceDetails();
            ClearInvoice();
            ClearInvoiceDetails();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            // Ensure that a product is selected
            if (cboProductName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure that the invoice ID is not empty
            if (string.IsNullOrEmpty(txtInvoiceId.Text.Trim()))
            {
                MessageBox.Show("Please select an invoice to add details to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the invoice detail from the form fields
            InvoiceDetail invoiceDetail = new InvoiceDetail
            {
                InvoiceId = txtInvoiceId.Text.Trim(),
                ProductId = cboProductName.SelectedValue?.ToString() ?? string.Empty,
                UnitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) ? unitPrice : 0,
                Quantity = int.TryParse(txtQuantity.Text, out int quantity) ? quantity : 0,
            };

            // Validate the invoice detail
            if (string.IsNullOrEmpty(invoiceDetail.ProductId) || invoiceDetail.UnitPrice <= 0 || invoiceDetail.Quantity <= 0)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the invoice detail to the database
            invoiceDetailsServices.AddInvoiceDetail(invoiceDetail);
            MessageBox.Show("Invoice detail added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Refresh the invoice details DataGridView
            LoadAllInvoiceDetails();
            // Clear the invoice detail fields
            ClearInvoiceDetails();
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            // Ensure that an invoice detail is selected
            if (dgvInvoiceDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an invoice detail to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected invoice detail
            InvoiceDetail selectedDetail = (InvoiceDetail)dgvInvoiceDetails.SelectedRows[0].DataBoundItem;
            // Get the updated invoice detail from the form fields
            InvoiceDetail updatedDetail = new InvoiceDetail
            {
                Id = selectedDetail.Id, // Assuming Id is the primary key for InvoiceDetail
                InvoiceId = txtInvoiceId.Text.Trim(),
                ProductId = cboProductName.SelectedValue?.ToString() ?? string.Empty,
                UnitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) ? unitPrice : 0,
                Quantity = int.TryParse(txtQuantity.Text, out int quantity) ? quantity : 0,
            };

            // Validate the updated invoice detail
            if (string.IsNullOrEmpty(updatedDetail.ProductId) || updatedDetail.UnitPrice <= 0 || updatedDetail.Quantity <= 0)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the invoice detail in the database
            invoiceDetailsServices.UpdateInvoiceDetail(updatedDetail);
            MessageBox.Show("Invoice detail updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Refresh the invoice details DataGridView
            LoadAllInvoiceDetails();
            // Clear the invoice detail fields
            ClearInvoiceDetails();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            // Ensure that an invoice detail is selected
            if (dgvInvoiceDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an invoice detail to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected invoice detail
            InvoiceDetail selectedDetail = (InvoiceDetail)dgvInvoiceDetails.SelectedRows[0].DataBoundItem;

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this invoice detail?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the invoice detail from the database
                invoiceDetailsServices.DeleteInvoiceDetail(selectedDetail.Id);
                MessageBox.Show("Invoice detail deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh the invoice details DataGridView
                LoadAllInvoiceDetails();
                // Clear the invoice detail fields
                ClearInvoiceDetails();
            }
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                // Get the selected invoice
                Invoice selectedInvoice = (Invoice)dgvInvoices.SelectedRows[0].DataBoundItem;
                // Fill the controls with the selected invoice's data
                txtInvoiceId.Text = selectedInvoice.Id;
                cboCardHolder.SelectedValue = selectedInvoice.CardId;
                cboStaff.SelectedValue = selectedInvoice.StaffId;
                dtpDate.Value = selectedInvoice.Date;
                rdoPaid.Checked = selectedInvoice.Status;
            }
            else
            {
                // Clear the controls if no row is selected
                cboCardHolder.SelectedIndex = -1;
                cboStaff.SelectedIndex = -1;
                dtpDate.Value = DateTime.Now;
                rdoPaid.Checked = false;
            }
        }

        private void dgvInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Clear the form fields after adding or updating an invoice
        private void ClearInvoice()
        {
            // Clear the invoice fields
            txtInvoiceId.Clear();
            cboCardHolder.SelectedIndex = -1;
            cboStaff.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            rdoPaid.Checked = false;

        }


        //Clear the invoice details fields
        private void ClearInvoiceDetails()
        {
            cboProductName.SelectedIndex = -1;
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtAmount.Clear();
        }

        private bool IsValidInvoice()
        {
            // Check if a membership card is selected
            if (cboCardHolder.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a membership card.");
                return false;
            }

            if (cboCardHolder.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid membership card.");
                return false;
            }

            // Check if a staff member is selected
            if (cboStaff.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a staff member.");
                return false;
            }

            if (cboStaff.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid staff member.");
                return false;
            }

            // If all checks pass, return true
            return true;
        }


        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Direct to the update section tab
            tabControl1.SelectedTab = tabPageInvoiceDetail;
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the unit price based on the selected product
            //if (cboProductName.SelectedValue != null)
            //{
            //    string productId = cboProductName.SelectedValue.ToString();
            //    Product selectedProduct = productServices.GetProductsByCriteria("ProductId", productId).FirstOrDefault();
            //    if (selectedProduct != null)
            //    {
            //        txtUnitPrice.Text = selectedProduct.Price.ToString("F2"); // Format to 2 decimal places
            //    }
            //    else
            //    {
            //        txtUnitPrice.Clear();
            //    }
            //}
            //else
            //{
            //    txtUnitPrice.Clear();`    
            //}
        }
    }
}

























//Get invoice detail from the form fields
//private InvoiceDetail GetInvoiceDetailFromForm()
//{
//    return new InvoiceDetail
//    {
//        InvoiceId = txtInvoiceId.Text.Trim(),
//        ProductId = cboProductName.SelectedValue?.ToString() ?? string.Empty,
//        UnitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) ? unitPrice : 0,
//        Quantity = int.TryParse(txtQuantity.Text, out int quantity) ? quantity : 0,
//    };
//}