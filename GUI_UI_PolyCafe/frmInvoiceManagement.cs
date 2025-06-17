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
using DAL_Data_PolyCafe;
using DAL_Data_PolyCafe.Constants;
using Microsoft.VisualBasic;
using DBUTIL_Utilities_PolyCafe.ValidationHelper;
using DBUTIL_Utilities_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class frmInvoiceManagement : Form
    {
        private readonly InvoiceServices invoiceServices;
        private readonly InvoiceDetailsServices invoiceDetailsServices;
        private readonly MembershipCardServices membershipCardServices;
        private readonly StaffServices staffServices;
        private readonly ProductServices productServices;
        private readonly InvoiceValidationHelper invoiceValidationHelper;
        private readonly InvoiceDetailsValidationHelper invoiceDetailsValidationHelper;

        private readonly string? _userId;

        public frmInvoiceManagement(string? userId = null)
        {
            invoiceServices = new InvoiceServices();
            invoiceDetailsServices = new InvoiceDetailsServices();
            membershipCardServices = new MembershipCardServices();
            staffServices = new StaffServices();
            invoiceValidationHelper = new InvoiceValidationHelper();
            invoiceDetailsValidationHelper = new InvoiceDetailsValidationHelper();
            productServices = new ProductServices();
            _userId = userId;
            InitializeComponent();
            SetupComponent();
            LoadForm();
            ClearInvoiceDetails();
        }


        private void SetupComponent()
        {
            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";

            // Set the DataGridView properties
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.AutoGenerateColumns = true;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgvInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceDetails.AutoGenerateColumns = true;
            dgvInvoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadForm()
        {
            LoadAllInvoices();
            LoadComboboxData();
        }

        private void LoadComboboxData()
        {
            //Set up ComboBox for Products
            cboProductName.DataSource = productServices.GetAllProducts();
            cboProductName.DisplayMember = "ProductName";
            cboProductName.ValueMember = "ProductId";
            cboProductName.SelectedIndex = -1;


            //Set up ComboBox for Membership Cards
            cboCardHolder.DataSource = membershipCardServices.GetAllMembershipCards();
            cboCardHolder.DisplayMember = "CardHolder";
            cboCardHolder.ValueMember = "CardId";
            cboCardHolder.SelectedIndex = -1;


            //Set up ComboBox for Staff
            cboStaff.DataSource = staffServices.GetAllStaff();
            cboStaff.DisplayMember = "FullName";
            cboStaff.ValueMember = "Id";
            cboStaff.SelectedIndex = -1;
        }

        //Load all invoices with criteria based on user ID
        private void LoadAllInvoices()
        {
            try
            {
                List<Invoice> invoices;
                if (_userId != null)
                {
                    // Load invoices by staff ID if user ID is provided
                    invoices = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, _userId);
                    dgvInvoices.DataSource = invoices;
                }
                else
                {
                    // Load all invoices if no user ID is provided
                    invoices = invoiceServices.GetAllInvoices();
                    dgvInvoices.DataSource = invoices;
                }
            }
            catch (Exception e)
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get a new invoice object with the data from the form fields
                Invoice invoice = new Invoice
                {
                    Id = invoiceServices.GenerateInvoiceId(),
                    CardId = cboCardHolder.SelectedValue?.ToString() ?? string.Empty,
                    StaffId = cboStaff.SelectedValue?.ToString() ?? string.Empty,
                    Date = DateTime.Now,
                    Status = rdoPaid.Checked
                };


                if (invoice.Status == true)
                {
                    InvoiceDetail? invoiceDetail = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, invoice.Id).FirstOrDefault();
                    if (invoiceDetail == null)
                    {
                        MessageBox.Show("You cannot pay an invoice without details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                // Ensure that the selected values are not null before accessing them
                if (!invoiceValidationHelper.IsValidateInvoice(invoice))
                {
                    MessageBox.Show(invoiceValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the selected invoice ID
            string invoiceId = txtInvoiceId.Text.Trim();
            if (string.IsNullOrEmpty(invoiceId))
            {
                MessageBox.Show("Please select an invoice to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Invoice? selectedInvoice = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, invoiceId).FirstOrDefault();
            InvoiceDetail? selectedDetail = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, invoiceId).FirstOrDefault();


            //Check if the invoice exists in the database
            if (selectedInvoice == null)
            {
                MessageBox.Show("The selected invoice does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Check if the invoice has details
            if (selectedDetail != null)
            {
                MessageBox.Show("You cannot update an invoice that already has details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Get the updated invoice object with the data from the form fields
            Invoice updateInvoice = new Invoice
            {
                Id = invoiceId,
                CardId = cboCardHolder.SelectedValue?.ToString(),
                Date = dtpDate.Value,
                Status = rdoPaid.Checked
            };


            //Check if the changed invoice is relative to another staff member
            if (selectedInvoice.StaffId != updateInvoice.StaffId && !AuthUtil.IsManager())
            {
                MessageBox.Show("You can only update your own invoices.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Check if the invoice is valid before updating
            if (!invoiceValidationHelper.IsValidateInvoice(updateInvoice))
            {
                MessageBox.Show(invoiceValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the invoice in the database
            int result = invoiceServices.UpdateInvoice(updateInvoice);
            if (result > 0)
            {
                MessageBox.Show("Invoice updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInvoices.DataSource = invoiceServices.GetAllInvoices();
                ClearInvoice();
                LoadAllInvoiceDetails();
            }
            else
            {
                MessageBox.Show("Failed to update invoice. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInvoiceId.Text))
            {
                MessageBox.Show("Please select a invoice to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Check if the invoice is paid
            Invoice? invoice = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, txtInvoiceId.Text.Trim()).FirstOrDefault();
            if (invoice != null && invoice.Status)
            {
                MessageBox.Show("You cannot delete a paid invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string invoiceId = txtInvoiceId.Text;
                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this invoice?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Delete the invoice from the database
                int rowsAffected = invoiceServices.DeleteInvoice(invoiceId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Invoice deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllInvoices();
                    ClearInvoice();
                }
                else
                {
                    MessageBox.Show("Failed to delete invoice. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            // Ensure that the invoice ID is not empty
            if (string.IsNullOrEmpty(txtInvoiceId.Text.Trim()))
            {
                MessageBox.Show("Please select an invoice to add details to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Invoice? invoice = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, txtInvoiceId.Text.Trim()).FirstOrDefault();


            //Check if the invoice exists
            if (invoice == null)
            {
                MessageBox.Show("The selected invoice does not exist in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the invoice is already paid
            if (invoice != null && invoice.Status)
            {
                MessageBox.Show("You cannot add details to a paid invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!invoiceDetailsValidationHelper.IsValidInvoiceDetail(invoiceDetail))
            {
                MessageBox.Show(invoiceDetailsValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Add the invoice detail to the database
            invoiceDetailsServices.AddInvoiceDetail(invoiceDetail);
            MessageBox.Show("Invoice detail added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllInvoiceDetails();
            LoadAllInvoices();
            ClearInvoiceDetails();
            ClearInvoice();
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if the invoiceId detail is selected
                if (string.IsNullOrEmpty(txtInvoiceId.Text))
                {
                    MessageBox.Show("Please select an invoice to update details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Check if the details is exist
                if (invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text.Trim()).Count == 0)
                {
                    MessageBox.Show("No invoice details found for the selected invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //Check if the invoid is already paid, if so cannot update the details
                Invoice? invoice = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, txtInvoiceId.Text.Trim()).FirstOrDefault();
                if (invoice != null)
                {
                    if (invoice.Status)
                    {
                        MessageBox.Show("You cannot update details for a paid invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                // Get the updated invoice detail from the form fields
                InvoiceDetail updatedDetail = new InvoiceDetail
                {
                    Id = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text.Trim()).FirstOrDefault()?.Id ?? 0,
                    InvoiceId = txtInvoiceId.Text.Trim(),
                    ProductId = cboProductName.SelectedValue?.ToString() ?? string.Empty,
                    UnitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) ? unitPrice : 0,
                    Quantity = int.TryParse(txtQuantity.Text, out int quantity) ? quantity : 0,
                };


                // Validate the updated invoice detail
                if (!invoiceDetailsValidationHelper.IsValidInvoiceDetail(updatedDetail))
                {
                    MessageBox.Show(invoiceDetailsValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Update the invoice detail in the database
                invoiceDetailsServices.UpdateInvoiceDetail(updatedDetail);
                MessageBox.Show("Invoice detail updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllInvoiceDetails();
                ClearInvoiceDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating invoice detail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            //Check if the invoiceId detail is selected
            if (string.IsNullOrEmpty(txtInvoiceId.Text))
            {
                MessageBox.Show("Please select an invoice to update details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the details is exist
            if (invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text.Trim()).Count == 0)
            {
                MessageBox.Show("No invoice details found for the selected invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Check if the invoid is already paid, if so cannot delete the details
            Invoice? invoice = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, txtInvoiceId.Text.Trim()).FirstOrDefault();
            if (invoice != null)
            {
                if (invoice.Status)
                {
                    MessageBox.Show("You cannot delete details for a paid invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int selectedDetailId = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text.Trim()).FirstOrDefault()?.Id ?? 0;
            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this invoice detail?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                invoiceDetailsServices.DeleteInvoiceDetail(selectedDetailId);
                MessageBox.Show("Invoice detail deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllInvoiceDetails();
                ClearInvoiceDetails();
            }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            // Check if the invoice ID is selected
            if (string.IsNullOrEmpty(txtInvoiceId.Text.Trim()))
            {
                MessageBox.Show("Please select an invoice to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Invoice? invoice = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, txtInvoiceId.Text.Trim()).FirstOrDefault();
            InvoiceDetail? invoiceDetail = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text.Trim()).FirstOrDefault();

            //Check if the invoice is exist
            if (invoice == null)
            {
                MessageBox.Show("The selected invoice does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the invoice is paid
            if (invoice != null && invoice.Status)
            {
                MessageBox.Show("This invoice is already paid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the invoice details is exist
            if (invoiceDetail == null)
            {
                MessageBox.Show("No invoice details found for the selected invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Check if the invoice is valid
            if (invoice ==null || !invoiceValidationHelper.IsValidateInvoice(invoice))
            {
                MessageBox.Show(invoiceValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Check if the details is valid
            if (invoiceDetail == null || !invoiceDetailsValidationHelper.IsValidInvoiceDetail(invoiceDetail))
            {
                MessageBox.Show(invoiceDetailsValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm payment
            DialogResult result = MessageBox.Show("Are you sure you want to pay this invoice?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                invoice.Status = true;
                invoiceServices.UpdateInvoice(invoice);
                MessageBox.Show("Invoice paid successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdoPaid.Checked = true;
                rdoUnpaid.Checked = false;
                LoadAllInvoices();
            }
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a row is selected
            if (e.RowIndex >= 0 && e.RowIndex < dgvInvoices.Rows.Count)
            {
                // Get the selected invoice
                DataGridViewRow selectedRow = dgvInvoices.Rows[e.RowIndex];
                Invoice selectedInvoice = (Invoice)selectedRow.DataBoundItem;
                // Populate the form fields with the selected invoice data
                txtInvoiceId.Text = selectedInvoice.Id;
                cboCardHolder.SelectedValue = selectedInvoice.CardId;
                cboStaff.SelectedValue = selectedInvoice.StaffId;
                dtpDate.Value = Convert.ToDateTime(selectedInvoice.Date);
                rdoPaid.Checked = selectedInvoice.Status;
                rdoUnpaid.Checked = !selectedInvoice.Status;

                ClearInvoiceDetails();
            }
        }

        private void dgvInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvInvoiceDetails.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvInvoiceDetails.Rows[e.RowIndex];
                InvoiceDetail selectedDetail = (InvoiceDetail)selectedRow.DataBoundItem;

                // Populate the form fields with the selected invoice detail data
                cboProductName.SelectedValue = selectedDetail.ProductId;
                txtUnitPrice.Text = selectedDetail.UnitPrice.ToString("F2");
                txtQuantity.Text = selectedDetail.Quantity.ToString();
                txtAmount.Text = (selectedDetail.UnitPrice * selectedDetail.Quantity).ToString("F2");

                // Set the invoice ID for the detail
                Invoice? invoice = invoiceServices.GetInvoicesByCriteria(InvoiceColumns.Id, selectedDetail.InvoiceId).FirstOrDefault();
                if (invoice != null)
                {
                    txtInvoiceId.Text = invoice.Id;
                    cboCardHolder.SelectedValue = invoice.CardId;
                    cboStaff.SelectedValue = invoice.StaffId;
                    dtpDate.Value = Convert.ToDateTime(invoice.Date);
                    rdoPaid.Checked = invoice.Status;
                }

                tabControl.SelectedTab = tabPageInvoice;
            }
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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadForm();
            ClearInvoice();
            ClearInvoiceDetails();
        }


        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl.SelectedTab = tabPageInvoiceDetail;

            List<InvoiceDetail> invoiceDetails = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text.Trim());
            if (invoiceDetails != null && invoiceDetails.Count > 0)
            {
                dgvInvoiceDetails.DataSource = invoiceDetails;
            }
            else
            {
                MessageBox.Show("No invoice details found for the selected invoice.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInvoiceDetails.DataSource = null;
            }
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductName.SelectedItem is Product selectedProduct)
            {
                txtUnitPrice.Text = selectedProduct.UnitPrice.ToString("F2");
            }

            CalculateTotalAmount();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }


        //Calculate the total amount for the invoice
        private void CalculateTotalAmount()
        {
            if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) && int.TryParse(txtQuantity.Text, out int quantity))
            {
                decimal amount = unitPrice * quantity;
                txtAmount.Text = amount.ToString("F2");
            }
            else
            {
                txtAmount.Clear();
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (txtInvoiceId.Text != null)
            {
                List<InvoiceDetail> invoiceDetails = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text.Trim());
                if (invoiceDetails != null && invoiceDetails.Count > 0)
                {
                    dgvInvoiceDetails.DataSource = invoiceDetails;
                }
                else
                {
                    dgvInvoiceDetails.DataSource = null;
                }
            }
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



//Load all invoices
//private void LoadAllInvoices()
//{
//    try
//    {
//        var invoices = invoiceServices.GetAllInvoices();
//        if (invoices != null && invoices.Count > 0)
//        {
//            dgvInvoices.DataSource = invoices;
//        }
//        else
//        {
//            MessageBox.Show("No invoices found.");
//            dgvInvoices.DataSource = null;
//        }
//    }
//    catch (Exception e )
//    {
//        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        dgvInvoices.DataSource = null;
//    }
//}



//Load invoice by staff ID criteria
//private void LoadInvoicesByStaffId(string staffId)
//{
//    try
//    {
//        var invoices = invoiceServices.GetInvoicesByCriteria("StaffId", staffId);
//        if (invoices != null && invoices.Count > 0)
//        {
//            dgvInvoices.DataSource = invoices;
//        }
//        else
//        {
//            MessageBox.Show("No invoices found for the selected staff.");
//            dgvInvoices.DataSource = null;
//        }
//    }
//    catch (Exception e)
//    {
//        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        dgvInvoices.DataSource = null;
//    }
//}



//Get invoice from the form fields
//private Invoice GetInvoiceFromForm()
//{
//    return new Invoice
//    {
//        Id = invoiceServices.GenerateInvoiceId(),
//        CardId = cboCardHolder.SelectedValue?.ToString() ?? string.Empty,
//        StaffId = cboStaff.SelectedValue?.ToString() ?? string.Empty,
//        Date = dtpDate.Value,
//        Status = rdoPaid.Checked
//    };
//}


//InvoiceDetail? invoiceDetail = invoiceDetailsServices.GetInvoiceDetailsByCriteria(InvoiceDetailColumns.InvoiceId, txtInvoiceId.Text).FirstOrDefault();
//if (invoiceDetail != null)
//{
//    cboProductName.SelectedValue = invoiceDetail.ProductId;
//    txtUnitPrice.Text = invoiceDetail.UnitPrice.ToString("F2");
//    txtQuantity.Text = invoiceDetail.Quantity.ToString();
//    txtAmount.Text = (invoiceDetail.UnitPrice * invoiceDetail.Quantity).ToString("F2");
//}
//else
//{
//    ClearInvoiceDetails();
//}