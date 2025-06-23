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
    public partial class frmProductCategories : Form
    {
        private ProductCategoryServices ProductCategoryServices { get; set; }
        public frmProductCategories()
        {
            ProductCategoryServices = new ProductCategoryServices();
            InitializeComponent();
            SetupComponent(dgvProductCategories);
            LoadProductCategories();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void LoadProductCategories()
        {
            try
            {
                var categories = ProductCategoryServices.GetAllProductCategories();
                dgvProductCategories.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                //Get a new product category object with the data from the form fields
                var newCategory = new ProductCategory
                {
                    CategoryId = ProductCategoryServices.GenerateProductCategoryId(),
                    CategoryName = txtCategoryName.Text.Trim(),
                    Notes = txtNotes.Text.Trim()
                };

                // Validate the new category
                if (!IsValidProductCategory(newCategory))
                {
                    return;
                }

                int result = ProductCategoryServices.AddProductCategory(newCategory);
                if (result > 0)
                {
                    MessageBox.Show("Product category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductCategories();
                }
                else
                {
                    MessageBox.Show("Failed to add product category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryId.Text))
            {
                MessageBox.Show("Please select a product category to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Get the product category object with the data from the form fields
            var updatedCategory = new ProductCategory
            {
                CategoryId = txtCategoryId.Text.Trim(),
                CategoryName = txtCategoryName.Text.Trim(),
                Notes = txtNotes.Text.Trim()
            };

            // Validate the updated category
            if (!IsValidProductCategory(updatedCategory))
            {
                return;
            }

            try
            {
                int result = ProductCategoryServices.UpdateProductCategory(updatedCategory);
                if (result > 0)
                {
                    MessageBox.Show("Product category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductCategories();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update product category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a category is selected
            if (string.IsNullOrWhiteSpace(txtCategoryId.Text))
            {
                MessageBox.Show("Please select a product category to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //Ask for confirmation before deleting
                var confirmResult = MessageBox.Show("Are you sure you want to delete this product category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                string categoryId = txtCategoryId.Text.Trim();
                int result = ProductCategoryServices.DeleteProductCategory(categoryId);
                if (result > 0)
                {
                    MessageBox.Show("Product category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductCategories();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete product category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadProductCategories();
        }


        private void ClearInputFields()
        {
            txtCategoryId.Clear();
            txtCategoryName.Clear();
            txtNotes.Clear();
        }


        private void dgvProductCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if a row is selected
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductCategories.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvProductCategories.Rows[e.RowIndex];
                ProductCategory selectedCategory = (ProductCategory)selectedRow.DataBoundItem;
                // Fill the input fields with the selected category's data
                txtCategoryId.Text = selectedCategory.CategoryId;
                txtCategoryName.Text = selectedCategory.CategoryName;
                txtNotes.Text = selectedCategory.Notes;

                tabControl.SelectedTab = tabPageUpdate;
            }
            else
            {
                // Clear the input fields if no row is selected
                ClearInputFields();
            }
        }


        //Check if the ProductCAtegory is valid
        private bool IsValidProductCategory(ProductCategory category)
        {
            if (category == null)
            {
                MessageBox.Show("Product category cannot be null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(category.CategoryId) || string.IsNullOrEmpty(category.CategoryName))
            {
                MessageBox.Show("Category ID and Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvProductCategories_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProductCategories.Columns["CategoryId"].HeaderText = "Mã loại";
            dgvProductCategories.Columns["CategoryName"].HeaderText = "Tên loại";
            dgvProductCategories.Columns["Notes"].HeaderText = "Ghi chú";
        }
    }
}
