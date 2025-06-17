namespace GUI_UI_PolyCafe
{
    partial class frmInvoiceManagement : Form
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
            tabControl = new TabControl();
            tabPageInvoice = new TabPage();
            btnDeleteDetail = new Button();
            btnPay = new Button();
            btnUpdateDetail = new Button();
            btnRefresh = new Button();
            btnAddDetail = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvInvoices = new DataGridView();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label5 = new Label();
            txtUnitPrice = new TextBox();
            label6 = new Label();
            cboProductName = new ComboBox();
            txtAmount = new TextBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dtpDate = new DateTimePicker();
            rdoUnpaid = new RadioButton();
            rdoPaid = new RadioButton();
            cboStaff = new ComboBox();
            label8 = new Label();
            cboCardHolder = new ComboBox();
            label3 = new Label();
            txtInvoiceId = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageInvoiceDetail = new TabPage();
            dgvInvoiceDetails = new DataGridView();
            tabControl.SuspendLayout();
            tabPageInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageInvoiceDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageInvoice);
            tabControl.Controls.Add(tabPageInvoiceDetail);
            tabControl.Location = new Point(7, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(2253, 1403);
            tabControl.TabIndex = 0;
            tabControl.Selected += tabControl_Selected;
            // 
            // tabPageInvoice
            // 
            tabPageInvoice.Controls.Add(btnDeleteDetail);
            tabPageInvoice.Controls.Add(btnPay);
            tabPageInvoice.Controls.Add(btnUpdateDetail);
            tabPageInvoice.Controls.Add(btnRefresh);
            tabPageInvoice.Controls.Add(btnAddDetail);
            tabPageInvoice.Controls.Add(btnDelete);
            tabPageInvoice.Controls.Add(btnUpdate);
            tabPageInvoice.Controls.Add(btnAdd);
            tabPageInvoice.Controls.Add(dgvInvoices);
            tabPageInvoice.Controls.Add(groupBox2);
            tabPageInvoice.Controls.Add(groupBox1);
            tabPageInvoice.Controls.Add(label1);
            tabPageInvoice.Location = new Point(10, 55);
            tabPageInvoice.Name = "tabPageInvoice";
            tabPageInvoice.Padding = new Padding(3);
            tabPageInvoice.Size = new Size(2233, 1338);
            tabPageInvoice.TabIndex = 0;
            tabPageInvoice.Text = "PHIẾU BÁN HÀNG   ";
            tabPageInvoice.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDetail
            // 
            btnDeleteDetail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteDetail.ForeColor = Color.Firebrick;
            btnDeleteDetail.Location = new Point(2005, 645);
            btnDeleteDetail.Name = "btnDeleteDetail";
            btnDeleteDetail.Size = new Size(207, 85);
            btnDeleteDetail.TabIndex = 3;
            btnDeleteDetail.Text = "Xóa chi tiết";
            btnDeleteDetail.UseVisualStyleBackColor = true;
            btnDeleteDetail.Click += btnDeleteDetail_Click;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPay.ForeColor = SystemColors.HotTrack;
            btnPay.Location = new Point(1163, 645);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(215, 85);
            btnPay.TabIndex = 3;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnUpdateDetail
            // 
            btnUpdateDetail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdateDetail.ForeColor = Color.DarkOrange;
            btnUpdateDetail.Location = new Point(1736, 645);
            btnUpdateDetail.Name = "btnUpdateDetail";
            btnUpdateDetail.Size = new Size(207, 85);
            btnUpdateDetail.TabIndex = 3;
            btnUpdateDetail.Text = "Sửa chi tiết";
            btnUpdateDetail.UseVisualStyleBackColor = true;
            btnUpdateDetail.Click += btnUpdateDetail_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.DeepSkyBlue;
            btnRefresh.Location = new Point(894, 645);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(215, 85);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddDetail
            // 
            btnAddDetail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddDetail.ForeColor = Color.Green;
            btnAddDetail.Location = new Point(1444, 645);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(239, 85);
            btnAddDetail.TabIndex = 3;
            btnAddDetail.Text = "Thêm chi tiết";
            btnAddDetail.UseVisualStyleBackColor = true;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(609, 645);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 85);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa phiếu";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.DarkOrange;
            btnUpdate.Location = new Point(336, 645);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(215, 85);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Sửa phiếu";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.ForestGreen;
            btnAdd.Location = new Point(51, 645);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(215, 85);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm phiếu";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvInvoices
            // 
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(6, 762);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.RowHeadersWidth = 92;
            dgvInvoices.Size = new Size(2221, 570);
            dgvInvoices.TabIndex = 2;
            dgvInvoices.CellClick += dgvInvoices_CellClick;
            dgvInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtUnitPrice);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cboProductName);
            groupBox2.Controls.Add(txtAmount);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(1449, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(763, 527);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Phiếu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(49, 421);
            label7.Name = "label7";
            label7.Size = new Size(202, 48);
            label7.TabIndex = 0;
            label7.Text = "Thành Tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(49, 195);
            label5.Name = "label5";
            label5.Size = new Size(153, 48);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(287, 181);
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(448, 61);
            txtUnitPrice.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(49, 304);
            label6.Name = "label6";
            label6.Size = new Size(179, 48);
            label6.TabIndex = 0;
            label6.Text = "Số Lượng:";
            // 
            // cboProductName
            // 
            cboProductName.FormattingEnabled = true;
            cboProductName.Location = new Point(287, 74);
            cboProductName.Name = "cboProductName";
            cboProductName.Size = new Size(448, 45);
            cboProductName.TabIndex = 2;
            cboProductName.SelectedIndexChanged += cboProductName_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(287, 408);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(448, 61);
            txtAmount.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(287, 292);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(448, 61);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(49, 74);
            label4.Name = "label4";
            label4.Size = new Size(185, 48);
            label4.TabIndex = 0;
            label4.Text = "Sản phẩm:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(rdoUnpaid);
            groupBox1.Controls.Add(rdoPaid);
            groupBox1.Controls.Add(cboStaff);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboCardHolder);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtInvoiceId);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1392, 527);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phiếu";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(936, 232);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(435, 43);
            dtpDate.TabIndex = 4;
            // 
            // rdoUnpaid
            // 
            rdoUnpaid.AutoCheck = false;
            rdoUnpaid.AutoSize = true;
            rdoUnpaid.Font = new Font("Segoe UI", 12F);
            rdoUnpaid.Location = new Point(584, 359);
            rdoUnpaid.Name = "rdoUnpaid";
            rdoUnpaid.Size = new Size(323, 52);
            rdoUnpaid.TabIndex = 3;
            rdoUnpaid.Text = "Chưa Thanh Toán";
            rdoUnpaid.UseVisualStyleBackColor = true;
            // 
            // rdoPaid
            // 
            rdoPaid.AutoCheck = false;
            rdoPaid.AutoSize = true;
            rdoPaid.Font = new Font("Segoe UI", 12F);
            rdoPaid.Location = new Point(263, 359);
            rdoPaid.Name = "rdoPaid";
            rdoPaid.Size = new Size(275, 52);
            rdoPaid.TabIndex = 3;
            rdoPaid.Text = "Đã thanh toán";
            rdoPaid.UseVisualStyleBackColor = true;
            // 
            // cboStaff
            // 
            cboStaff.FormattingEnabled = true;
            cboStaff.Location = new Point(263, 234);
            cboStaff.Name = "cboStaff";
            cboStaff.Size = new Size(415, 45);
            cboStaff.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(746, 227);
            label8.Name = "label8";
            label8.Size = new Size(172, 48);
            label8.TabIndex = 0;
            label8.Text = "Ngày tạo:";
            // 
            // cboCardHolder
            // 
            cboCardHolder.FormattingEnabled = true;
            cboCardHolder.Location = new Point(936, 96);
            cboCardHolder.Name = "cboCardHolder";
            cboCardHolder.Size = new Size(435, 45);
            cboCardHolder.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(746, 96);
            label3.Name = "label3";
            label3.Size = new Size(128, 45);
            label3.TabIndex = 0;
            label3.Text = "Tên KH:";
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Location = new Point(263, 93);
            txtInvoiceId.Multiline = true;
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.ReadOnly = true;
            txtInvoiceId.Size = new Size(415, 53);
            txtInvoiceId.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(12, 361);
            label10.Name = "label10";
            label10.Size = new Size(185, 48);
            label10.TabIndex = 0;
            label10.Text = "Trạng thái:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(12, 233);
            label9.Name = "label9";
            label9.Size = new Size(245, 48);
            label9.TabIndex = 0;
            label9.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(177, 48);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(892, 26);
            label1.Name = "label1";
            label1.Size = new Size(442, 65);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU BÁN HÀNG";
            // 
            // tabPageInvoiceDetail
            // 
            tabPageInvoiceDetail.Controls.Add(dgvInvoiceDetails);
            tabPageInvoiceDetail.Location = new Point(10, 55);
            tabPageInvoiceDetail.Name = "tabPageInvoiceDetail";
            tabPageInvoiceDetail.Padding = new Padding(3);
            tabPageInvoiceDetail.Size = new Size(2233, 1338);
            tabPageInvoiceDetail.TabIndex = 1;
            tabPageInvoiceDetail.Text = "CHI TIẾT PHIẾU  ";
            tabPageInvoiceDetail.UseVisualStyleBackColor = true;
            // 
            // dgvInvoiceDetails
            // 
            dgvInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceDetails.Location = new Point(6, 6);
            dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            dgvInvoiceDetails.RowHeadersWidth = 92;
            dgvInvoiceDetails.Size = new Size(2221, 1306);
            dgvInvoiceDetails.TabIndex = 0;
            dgvInvoiceDetails.CellClick += dgvInvoiceDetails_CellClick;
            // 
            // frmInvoiceManagement
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(tabControl);
            Name = "frmInvoiceManagement";
            Text = "Quản lý phiếu bán hàng";
            tabControl.ResumeLayout(false);
            tabPageInvoice.ResumeLayout(false);
            tabPageInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageInvoiceDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageInvoice;
        private Label label1;
        private TabPage tabPageInvoiceDetail;
        private DataGridView dgvInvoices;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label4;
        private TextBox txtProductName;
        private GroupBox groupBox1;
        private ComboBox cboCardHolder;
        private Label label3;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox txtQuantity;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox txtInvoiceId;
        private Label label9;
        private Label label2;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private RadioButton radioButton2;
        private RadioButton rdoPaid;
        private Label label10;
        private Button btnDeleteDetail;
        private Button btnPay;
        private Button btnUpdateDetail;
        private Button btnAddDetail;
        private DataGridView dgvInvoiceDetails;
        private ComboBox cboStaff;
        private DateTimePicker dtpDate;
        private ComboBox cboProductName;
        private RadioButton rdoUnpaid;
        private TextBox txtAmount;
    }
}