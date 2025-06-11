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

namespace GUI_UI_PolyCafe
{
    public partial class frmProduct : Form
    {
        private ProductServices ProductServices { get; set; }
        public frmProduct()
        {
            ProductServices = new ProductServices();
            InitializeComponent();
            SetupComponent(dgvProdusts);
            LoadAllProducts();
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

        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bthDelete_Click(object sender, EventArgs e)
        {

        }

        private void bthRefresh_Click(object sender, EventArgs e)
        {

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
    }
}
