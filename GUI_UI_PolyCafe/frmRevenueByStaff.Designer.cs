namespace GUI_UI_PolyCafe
{
    partial class frmRevenueByStaff
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
            dgvReport = new DataGridView();
            panel1 = new Panel();
            btnExport = new Button();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            cboEmployee = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(21, 193);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 92;
            dgvReport.Size = new Size(2239, 1216);
            dgvReport.TabIndex = 3;
            dgvReport.CellFormatting += dgvReport_CellFormatting;
            dgvReport.DataBindingComplete += dgvReport_DataBindingComplete;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(dtpToDate);
            panel1.Controls.Add(dtpFromDate);
            panel1.Controls.Add(cboEmployee);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(2248, 157);
            panel1.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.CornflowerBlue;
            btnExport.BackgroundImageLayout = ImageLayout.Zoom;
            btnExport.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Transparent;
            btnExport.Location = new Point(2026, 31);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(194, 79);
            btnExport.TabIndex = 3;
            btnExport.Text = "Thống kê";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(1493, 56);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(450, 43);
            dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(839, 54);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(428, 43);
            dtpFromDate.TabIndex = 2;
            // 
            // cboEmployee
            // 
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(241, 52);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(423, 45);
            cboEmployee.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1328, 55);
            label3.Name = "label3";
            label3.Size = new Size(159, 45);
            label3.TabIndex = 0;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(697, 55);
            label2.Name = "label2";
            label2.Size = new Size(136, 45);
            label2.TabIndex = 0;
            label2.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 51);
            label1.Name = "label1";
            label1.Size = new Size(169, 45);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // frmRevenueByStaff
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(dgvReport);
            Controls.Add(panel1);
            Name = "frmRevenueByStaff";
            Text = "Thống kê doanh thu theo nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReport;
        private Panel panel1;
        private Button btnExport;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private ComboBox cboEmployee;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}