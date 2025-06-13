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
using DBUTIL_Utilities_PolyCafe;
using DTO_Models_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class frmProduct : Form
    {
        private ProductServices ProductServices { get; set; }
        private ProductCategoryServices ProductCategoryServices { get; set; }
        public frmProduct()
        {
            ProductServices = new ProductServices();
            ProductCategoryServices = new ProductCategoryServices();
            InitializeComponent();
            SetupComponent(dgvProdusts);

        }

        private void LoadAllProducts()
        {
            try
            {
                var products = ProductServices.GetAllProducts();
                if (products != null && products.Count > 0)
                {
                    dgvProdusts.DataSource = products;
                }
                else
                {
                    MessageBox.Show("No products found.");
                    dgvProdusts.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvProdusts.DataSource = null;
            }
        }


        private void LoadAllProductCategories()
        {
            try
            {
                List<ProductCategory> productCategories = ProductCategoryServices.GetAllProductCategories();
                if (productCategories != null && productCategories.Count > 0)
                {
                    cboProductCategories.DataSource = productCategories;
                }
                else
                {
                    MessageBox.Show("No product category found.");
                    cboProductCategories.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading product category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProductCategories = null;
            }
        }

        private void SetupComponent(DataGridView dataGridView)
        {
            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            // Set the DataGridView properties
            LoadAllProducts();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //Set up combox
            LoadAllProductCategories();
            cboProductCategories.DisplayMember = "CategoryName";
            cboProductCategories.ValueMember = "CategoryId";
            cboProductCategories.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Get a new membership card object with the data from the form fields
                Product product = new Product
                {
                    ProductId = ProductServices.GenerateProductId(),
                    ProductName = txtProductName.Text,
                    Price = decimal.Parse(txtUnitPrice.Text),
                    CategoryId = cboProductCategories.SelectedValue?.ToString(),
                    Image = " ",
                    Status = rdoActive.Checked
                };

                //Check if product is valid
                if (!IsValidProduct(product))
                {
                    return;
                }

                //Add product to database
                int result = ProductServices.AddProduct(product);
                if (result > 0)
                {
                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllProducts();
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
                if (string.IsNullOrWhiteSpace(txtProductId.Text))
                {
                    MessageBox.Show("Please select a staff member to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Get a new membership card object with the data from the form fields
                Product product = new Product
                {
                    ProductId = ProductServices.GenerateProductId(),
                    ProductName = txtProductName.Text,
                    Price = decimal.Parse(txtUnitPrice.Text),
                    CategoryId = cboProductCategories.SelectedValue?.ToString(),
                    Image = " ",
                    Status = rdoActive.Checked
                };

                //Check if product is valid
                if (!IsValidProduct(product))
                {
                    return;
                }

                //Update the product to the database
                int result = ProductServices.UpdateProduct(product);
                if (result > 0)
                {
                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllProducts();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void bthDelete_Click(object sender, EventArgs e)
        {
            //Check if the product is selected
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please select a product to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string productId = txtProductId.Text;
                var confirmResult = MessageBox.Show("Are you sure want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                int result = ProductServices.DeleteProduct(productId);
                if (result > 0)
                {
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllProducts();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bthRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadAllProducts();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                openFileDialog.Title = "Select a Product Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // Preview the image in a PictureBox (optional)
                    pictureBoxProduct.Image = Image.FromFile(selectedImagePath);

                    // Create folder and copy the image file. 
                    string newImagePath = ImageUtil.CopyImageToProjectFolder(selectedImagePath);

                    // Save the new image path to the database.
                    ProductServices.SaveImagePath(txtProductId.Text, newImagePath);
                }
            }
        }

        private void ClearInputFields()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();

        }


        //Check if the product is valid
        private bool IsValidProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        //Load the real image of product instead of its path in datagridview
        private void dgvProdusts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProdusts.Columns[e.ColumnIndex].Name == "Image" && e.Value != null)
            {
                string? imagePath = e.Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        e.Value = Bitmap.FromFile(imagePath);
                        e.FormattingApplied = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Value = null; 
                    }
                }
            }
        }


        private void dgvProdusts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdusts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProdusts.SelectedRows[0];
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                //Fill the input fields with the selected product's data
                txtProductId.Text = selectedProduct.ProductId;
                txtProductName.Text = selectedProduct.ProductName;
                txtUnitPrice.Text = selectedProduct.Price.ToString();
                cboProductCategories.SelectedValue = selectedProduct.CategoryId;
                rdoActive.Checked = selectedProduct.Status;


                if(selectedProduct.Image != null && selectedProduct.Image != " ")
                {
                    try
                    {
                        if (File.Exists(selectedProduct.Image))
                        {
                            pictureBoxProduct.Image = new Bitmap(selectedProduct.Image);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading product image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBoxProduct.Image = null;
                    }
                }
                else
                {
                    pictureBoxProduct.Image = null; 
                }

                ////Load the product image with the path from the database
                //if (!string.IsNullOrEmpty(selectedProduct.Image))
                //{
                //    try
                //    {
                //        pictureBoxProduct.Image = Image.FromFile(selectedProduct.Image);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show($"Error loading product image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        pictureBoxProduct.Image = null; // Clear the image if there's an error
                //    }
                //}
                //else
                //{
                //    pictureBoxProduct.Image = null; // Clear the image if no path is provided
                //}


                ////Load product image with Bitmap from the database
                //if (!string.IsNullOrEmpty(selectedProduct.Image))
                //{
                //    try
                //    {
                //        pictureBoxProduct.Image = ImageUtil.LoadImageFromFile(selectedProduct.Image);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show($"Error loading product image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        pictureBoxProduct.Image = null; // Clear the image if there's an error
                //    }
                //}
                //else
                //{
                //    pictureBoxProduct.Image = null; // Clear the image if no path is provided
                //}

                //Direct to update section tab
                tabControl1.SelectedTab = tabPageUpdate;
            }
        }
    }
}

