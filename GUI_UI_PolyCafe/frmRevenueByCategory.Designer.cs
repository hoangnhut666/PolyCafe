namespace GUI_UI_PolyCafe
{
    partial class frmRevenueByCategory
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
            panel1 = new Panel();
            btnExport = new Button();
            button1 = new Button();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            cboCategory = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvReport = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtpToDate);
            panel1.Controls.Add(dtpFromDate);
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 11F);
            panel1.Location = new Point(14, 15);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2698, 161);
            panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.CornflowerBlue;
            btnExport.BackgroundImageLayout = ImageLayout.Zoom;
            btnExport.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Transparent;
            btnExport.Location = new Point(2008, 36);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(194, 79);
            btnExport.TabIndex = 4;
            btnExport.Text = "Thống kê";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(2431, 38);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(233, 96);
            button1.TabIndex = 3;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = false;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(1476, 52);
            dtpToDate.Margin = new Padding(4);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(442, 51);
            dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(785, 53);
            dtpFromDate.Margin = new Padding(4);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(450, 51);
            dtpFromDate.TabIndex = 2;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(261, 54);
            cboCategory.Margin = new Padding(4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(339, 53);
            cboCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(1309, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 45);
            label3.TabIndex = 0;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(641, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 45);
            label2.TabIndex = 0;
            label2.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 45);
            label1.TabIndex = 0;
            label1.Text = "Loại sản phẩm";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(14, 184);
            dgvReport.Margin = new Padding(4);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 92;
            dgvReport.Size = new Size(2698, 1530);
            dgvReport.TabIndex = 1;
            dgvReport.CellFormatting += dgvReport_CellFormatting;
            dgvReport.DataBindingComplete += dgvReport_DataBindingComplete;
            // 
            // frmRevenueByCategory
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(dgvReport);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "frmRevenueByCategory";
            Text = "Thống Kê Doanh Thu Theo Loại Sản Phẩm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboCategory;
        private Label label2;
        private Label label1;
        private Button button1;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Label label3;
        private DataGridView dgvReport;
        private Button btnExport;
    }
}