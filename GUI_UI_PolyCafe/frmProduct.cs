using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
    public partial class frmProduct : Form
    {
        private ProductServices ProductServices { get; set; }
        private ProductCategoryServices ProductCategoryServices { get; set; }
        private ProductValidationHelper ProductValidationHelper { get; set; }
        public frmProduct()
        {
            ProductServices = new ProductServices();
            ProductCategoryServices = new ProductCategoryServices();
            ProductValidationHelper = new ProductValidationHelper();
            InitializeComponent();
            SetupComponent(dgvProducts);
        }

        private void LoadAllProducts()
        {
            var products = ProductServices.GetAllProducts();
            var productListWithImages = products.Select(p => new
            {
                p.ProductId,
                p.ProductName,
                p.UnitPrice,
                p.CategoryId,
                p.Status,
                Image = !string.IsNullOrEmpty(p.Image) && File.Exists(p.Image) ? LoadImageFromFile(p.Image) : null
            }).ToList();

            if (productListWithImages != null && productListWithImages.Count > 0)
            {
                dgvProducts.DataSource = productListWithImages;
            }
            else
            {
                MessageBox.Show("No products found.");
                dgvProducts.DataSource = null;
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
            dataGridView.RowTemplate.Height = 180;
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgvProducts.Columns["Image"];
            if (imageColumn != null)
            {
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }


            //Set up combox
            LoadAllProductCategories();
            cboProductCategories.DisplayMember = "CategoryName";
            cboProductCategories.ValueMember = "CategoryId";
            cboProductCategories.SelectedIndex = -1;

            //Set up picture box
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
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
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    CategoryId = cboProductCategories.SelectedValue?.ToString(),
                    Image = pictureBoxProduct.ImageLocation ?? " ",
                    Status = rdoActive.Checked
                };

                //Check if product is valid
                if (!ProductValidationHelper.IsValidProductId(product))
                {
                    MessageBox.Show(ProductValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    ProductId = txtProductId.Text,
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    CategoryId = cboProductCategories.SelectedValue?.ToString(),
                    Image = pictureBoxProduct.ImageLocation ?? " ",
                    Status = rdoActive.Checked
                };

                //Check if product is valid
                if (!ProductValidationHelper.IsValidProductId(product))
                {
                    MessageBox.Show(ProductValidationHelper.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                //Delete the product in new folder
                DeleteImageFile(pictureBoxProduct.ImageLocation);

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

                    // Create folder and copy the image file. 
                    string newImagePath = ImageUtil.CopyImageToProjectFolder(selectedImagePath);

                    //pictureBoxProduct.Image = Image.FromFile(newImagePath);
                    pictureBoxProduct.Image = LoadImageFromFile(newImagePath);
                    pictureBoxProduct.ImageLocation = newImagePath;

                }
            }
        }


        private void ClearInputFields()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            cboProductCategories.SelectedIndex = -1;
            rdoActive.Checked = true;
            pictureBoxProduct.Image = null;
        }


        private void dgvProdusts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProducts.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvProducts.Rows[e.RowIndex];
                txtProductId.Text = selectedRow.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                txtUnitPrice.Text = selectedRow.Cells["UnitPrice"].Value?.ToString();
                cboProductCategories.SelectedValue = selectedRow.Cells["CategoryId"].Value?.ToString();
                rdoActive.Checked = (bool)selectedRow.Cells["Status"].Value;
                pictureBoxProduct.Image = (Image)selectedRow.Cells["Image"].Value;

                tabControl1.SelectedTab = tabPageUpdate;
            }
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "CategoryId" && e.Value != null)
            {
                var categories = ProductCategoryServices.GetProductCategoriesByCriteria($"{ProductCategoryColumns.CategoryId}", e.Value.ToString());
                if (categories != null && categories.Count > 0)
                {
                    e.Value = categories[0].CategoryName;
                }
                else
                {
                    e.Value = "Unknown";
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadAllProducts();
        }


        public static Bitmap LoadImageFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified image file does not exist.", filePath);
            }
            try
            {
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    return new Bitmap(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading image from file.", ex);
            }
        }


        //Delete the image file from the project folder
        private void DeleteImageFile(string? imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    // Dispose the image if it's loaded in the PictureBox
                    if (pictureBoxProduct.Image != null)
                    {
                        pictureBoxProduct.Image.Dispose();
                    }
                    File.Delete(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting image file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                tabControl1.TabPages.Remove(tabPageUpdate);
            }
        }
    }
}




















//Load the real image of product instead of its path in datagridview
//private void dgvProdusts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
//{
//    if (dgvProdusts.Columns[e.ColumnIndex].Name == "Image" && e.Value != null)
//    {
//        string? imagePath = e.Value.ToString();
//        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
//        {
//            try
//            {
//                e.Value = Bitmap.FromFile(imagePath);
//                e.FormattingApplied = true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                e.Value = null;
//            }
//        }
//    }
//}



//private Image CreateThumbnail(string imagePath, int width = 100, int height = 100)
//{
//    try
//    {
//        //if (!File.Exists(imagePath))
//        //    return Properties.Resources.DefaultProductImage;

//        using (var originalImage = Image.FromFile(imagePath))
//        {
//            // Calculate aspect ratio
//            float ratio = Math.Min((float)width / originalImage.Width, (float)height / originalImage.Height);
//            int newWidth = (int)(originalImage.Width * ratio);
//            int newHeight = (int)(originalImage.Height * ratio);

//            var thumbnail = new Bitmap(newWidth, newHeight);
//            using (var graphics = Graphics.FromImage(thumbnail))
//            {
//                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
//                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
//            }
//            return thumbnail;
//        }
//    }
//    catch
//    {
//        return null; // or return a default image if you have one
//                     //return Properties.Resources.DefaultProductImage;
//    }
//}



//try
//{
//    var products = ProductServices.GetAllProducts();
//    if (products != null && products.Count > 0)
//    {
//        dgvProdusts.DataSource = products;
//    }
//    else
//    {
//        MessageBox.Show("No products found.");
//        dgvProdusts.DataSource = null;
//    }
//}
//catch (Exception ex)
//{
//    MessageBox.Show($"An error occurred while loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    dgvProdusts.DataSource = null;
//}


//if (dgvProdusts.SelectedRows.Count > 0)
//{
//    DataGridViewRow selectedRow = dgvProdusts.SelectedRows[0];
//    Product selectedProduct = (Product)selectedRow.DataBoundItem;

//    // Fill the input fields with the selected product's data
//    txtProductId.Text = selectedProduct.ProductId;
//    txtProductName.Text = selectedProduct.ProductName;
//    txtUnitPrice.Text = selectedProduct.Price.ToString();
//    cboProductCategories.SelectedValue = selectedProduct.CategoryId;
//    rdoActive.Checked = selectedProduct.Status;
//    pictureBoxProduct.Image = LoadImageFromFile(selectedProduct.Image);


//    tabControl1.SelectedTab = tabPageUpdate;
//}



//private void btnUploadImage_Click(object sender, EventArgs e)
//{
//    using (OpenFileDialog openFileDialog = new OpenFileDialog())
//    {
//        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
//        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
//        openFileDialog.Title = "Select a Product Image";

//        if (openFileDialog.ShowDialog() == DialogResult.OK)
//        {
//            string selectedImagePath = openFileDialog.FileName;

//            // Preview the image in a PictureBox (optional)
//            pictureBoxProduct.Image = Image.FromFile(selectedImagePath);

//            // Create folder and copy the image file. 
//            string newImagePath = ImageUtil.CopyImageToProjectFolder(selectedImagePath);

//            // Save the new image path to the database.
//            ProductServices.SaveImagePath(txtProductId.Text, newImagePath);

//            MessageBox.Show("Image uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//    }
//}


//private void btnSaveImage_Click(object sender, EventArgs e)
//{
//    // Check if an image is selected
//    if (pictureBoxProduct.Image == null)
//    {
//        MessageBox.Show("Please upload an image first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        return;
//    }

//    // Check if the product ID is valid
//    if (string.IsNullOrEmpty(txtProductId.Text))
//    {
//        MessageBox.Show("Please select a product to save the image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        return;
//    }

//    try
//    {
//        // Get the product ID from the text box
//        string productId = txtProductId.Text;
//        // Save the image path to the database
//        string imagePath = pictureBoxProduct.ImageLocation;
//        ProductServices.SaveImagePath(productId, imagePath);
//        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show($"An error occurred while saving the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}