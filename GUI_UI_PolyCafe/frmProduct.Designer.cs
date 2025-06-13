namespace GUI_UI_PolyCafe
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageUpdate = new TabPage();
            btnUploadImage = new Button();
            bthRefresh = new Button();
            bthDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            rdoInactive = new RadioButton();
            rdoActive = new RadioButton();
            cboProductCategories = new ComboBox();
            pictureBoxProduct = new PictureBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageList = new TabPage();
            dgvProducts = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUpdate);
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Location = new Point(3, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2257, 1410);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(btnUploadImage);
            tabPageUpdate.Controls.Add(bthRefresh);
            tabPageUpdate.Controls.Add(bthDelete);
            tabPageUpdate.Controls.Add(btnUpdate);
            tabPageUpdate.Controls.Add(btnAdd);
            tabPageUpdate.Controls.Add(rdoInactive);
            tabPageUpdate.Controls.Add(rdoActive);
            tabPageUpdate.Controls.Add(cboProductCategories);
            tabPageUpdate.Controls.Add(pictureBoxProduct);
            tabPageUpdate.Controls.Add(txtUnitPrice);
            tabPageUpdate.Controls.Add(txtProductName);
            tabPageUpdate.Controls.Add(txtProductId);
            tabPageUpdate.Controls.Add(label6);
            tabPageUpdate.Controls.Add(label5);
            tabPageUpdate.Controls.Add(label4);
            tabPageUpdate.Controls.Add(label3);
            tabPageUpdate.Controls.Add(label2);
            tabPageUpdate.Controls.Add(label1);
            tabPageUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageUpdate.Location = new Point(10, 63);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(2237, 1337);
            tabPageUpdate.TabIndex = 0;
            tabPageUpdate.Text = "CẬP NHẬT   ";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.FromArgb(162, 192, 248);
            btnUploadImage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadImage.Location = new Point(1704, 776);
            btnUploadImage.Margin = new Padding(4);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(249, 84);
            btnUploadImage.TabIndex = 21;
            btnUploadImage.Text = "Chọn hình";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // bthRefresh
            // 
            bthRefresh.BackColor = Color.FromArgb(162, 192, 248);
            bthRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            bthRefresh.Location = new Point(1278, 1080);
            bthRefresh.Margin = new Padding(4);
            bthRefresh.Name = "bthRefresh";
            bthRefresh.Size = new Size(249, 82);
            bthRefresh.TabIndex = 21;
            bthRefresh.Text = "Làm mới";
            bthRefresh.UseVisualStyleBackColor = false;
            bthRefresh.Click += bthRefresh_Click;
            // 
            // bthDelete
            // 
            bthDelete.BackColor = Color.FromArgb(162, 192, 248);
            bthDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            bthDelete.Location = new Point(910, 1080);
            bthDelete.Margin = new Padding(4);
            bthDelete.Name = "bthDelete";
            bthDelete.Size = new Size(249, 82);
            bthDelete.TabIndex = 21;
            bthDelete.Text = "Xóa";
            bthDelete.UseVisualStyleBackColor = false;
            bthDelete.Click += bthDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(162, 192, 248);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.Location = new Point(540, 1080);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(249, 82);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(162, 192, 248);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.Location = new Point(169, 1080);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(249, 82);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rdoInactive
            // 
            rdoInactive.AutoSize = true;
            rdoInactive.Font = new Font("Segoe UI", 11F);
            rdoInactive.Location = new Point(979, 875);
            rdoInactive.Margin = new Padding(4);
            rdoInactive.Name = "rdoInactive";
            rdoInactive.Size = new Size(216, 49);
            rdoInactive.TabIndex = 20;
            rdoInactive.TabStop = true;
            rdoInactive.Text = "Ngừng bán";
            rdoInactive.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            rdoActive.AutoSize = true;
            rdoActive.Font = new Font("Segoe UI", 11F);
            rdoActive.Location = new Point(593, 875);
            rdoActive.Margin = new Padding(4);
            rdoActive.Name = "rdoActive";
            rdoActive.Size = new Size(206, 49);
            rdoActive.TabIndex = 19;
            rdoActive.TabStop = true;
            rdoActive.Text = "Hoạt động";
            rdoActive.UseVisualStyleBackColor = true;
            // 
            // cboProductCategories
            // 
            cboProductCategories.FormattingEnabled = true;
            cboProductCategories.Location = new Point(592, 713);
            cboProductCategories.Margin = new Padding(4);
            cboProductCategories.Name = "cboProductCategories";
            cboProductCategories.Size = new Size(833, 53);
            cboProductCategories.TabIndex = 18;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Location = new Point(1531, 233);
            pictureBoxProduct.Margin = new Padding(4);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(622, 491);
            pictureBoxProduct.TabIndex = 16;
            pictureBoxProduct.TabStop = false;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(592, 546);
            txtUnitPrice.Margin = new Padding(4);
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(842, 70);
            txtUnitPrice.TabIndex = 15;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(592, 383);
            txtProductName.Margin = new Padding(4);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(842, 71);
            txtProductName.TabIndex = 14;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(592, 229);
            txtProductId.Margin = new Padding(4);
            txtProductId.Multiline = true;
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(842, 70);
            txtProductId.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(280, 875);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 45);
            label6.TabIndex = 11;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(280, 717);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(173, 45);
            label5.TabIndex = 10;
            label5.Text = "Sản phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(280, 560);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 45);
            label4.TabIndex = 9;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(280, 398);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(228, 45);
            label3.TabIndex = 8;
            label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(280, 242);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 45);
            label2.TabIndex = 12;
            label2.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(996, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 72);
            label1.TabIndex = 7;
            label1.Text = "SẢN PHẨM";
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dgvProducts);
            tabPageList.Location = new Point(10, 55);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(2237, 1345);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "DANH SÁCH";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(6, 17);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 92;
            dgvProducts.Size = new Size(2225, 1317);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProdusts_CellClick;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "frmProduct";
            Text = "Quản lý sản phẩm";
            tabControl1.ResumeLayout(false);
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageUpdate;
        private Button btnAdd;
        private RadioButton rdoInactive;
        private RadioButton rdoActive;
        private ComboBox cboProductCategories;
        private PictureBox pictureBoxProduct;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPageList;
        private Button btnUpdate;
        private Button btnUploadImage;
        private Button bthRefresh;
        private Button bthDelete;
        private DataGridView dgvProducts;
    }
}