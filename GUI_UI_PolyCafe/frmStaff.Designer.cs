namespace GUI_UI_PolyCafe
{
    partial class frmStaff
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
            tabPageUpdate = new TabPage();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            rdoInactive = new RadioButton();
            rdoManager = new RadioButton();
            rdoActive = new RadioButton();
            rdoEmployee = new RadioButton();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtStaffId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageList = new TabPage();
            dgvStaff = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tabControl.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageUpdate);
            tabControl.Controls.Add(tabPageList);
            tabControl.Location = new Point(3, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(2266, 1408);
            tabControl.TabIndex = 0;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(groupBox2);
            tabPageUpdate.Controls.Add(groupBox1);
            tabPageUpdate.Controls.Add(btnRefresh);
            tabPageUpdate.Controls.Add(btnDelete);
            tabPageUpdate.Controls.Add(btnUpdate);
            tabPageUpdate.Controls.Add(btnAdd);
            tabPageUpdate.Controls.Add(txtConfirmPassword);
            tabPageUpdate.Controls.Add(txtPassword);
            tabPageUpdate.Controls.Add(txtEmail);
            tabPageUpdate.Controls.Add(txtFullName);
            tabPageUpdate.Controls.Add(txtStaffId);
            tabPageUpdate.Controls.Add(label8);
            tabPageUpdate.Controls.Add(label7);
            tabPageUpdate.Controls.Add(label6);
            tabPageUpdate.Controls.Add(label5);
            tabPageUpdate.Controls.Add(label4);
            tabPageUpdate.Controls.Add(label3);
            tabPageUpdate.Controls.Add(label2);
            tabPageUpdate.Controls.Add(label1);
            tabPageUpdate.Location = new Point(10, 55);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(2246, 1343);
            tabPageUpdate.TabIndex = 0;
            tabPageUpdate.Text = "CẬP NHẬT";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(162, 192, 248);
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(1454, 1062);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(197, 73);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(162, 192, 248);
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1147, 1062);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(197, 73);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(162, 192, 248);
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(821, 1062);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(197, 73);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(162, 192, 248);
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(488, 1062);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(197, 73);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rdoInactive
            // 
            rdoInactive.AutoSize = true;
            rdoInactive.Font = new Font("Segoe UI", 12F);
            rdoInactive.Location = new Point(323, 42);
            rdoInactive.Name = "rdoInactive";
            rdoInactive.Size = new Size(335, 52);
            rdoInactive.TabIndex = 3;
            rdoInactive.TabStop = true;
            rdoInactive.Text = "Ngưng hoạt động";
            rdoInactive.UseVisualStyleBackColor = true;
            // 
            // rdoManager
            // 
            rdoManager.AutoSize = true;
            rdoManager.Font = new Font("Segoe UI", 12F);
            rdoManager.Location = new Point(323, 42);
            rdoManager.Name = "rdoManager";
            rdoManager.Size = new Size(172, 52);
            rdoManager.TabIndex = 3;
            rdoManager.TabStop = true;
            rdoManager.Text = "Quản lý";
            rdoManager.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            rdoActive.AutoSize = true;
            rdoActive.Font = new Font("Segoe UI", 12F);
            rdoActive.Location = new Point(27, 42);
            rdoActive.Name = "rdoActive";
            rdoActive.Size = new Size(221, 52);
            rdoActive.TabIndex = 3;
            rdoActive.TabStop = true;
            rdoActive.Text = "Hoạt động";
            rdoActive.UseVisualStyleBackColor = true;
            // 
            // rdoEmployee
            // 
            rdoEmployee.AutoSize = true;
            rdoEmployee.Font = new Font("Segoe UI", 12F);
            rdoEmployee.Location = new Point(27, 38);
            rdoEmployee.Name = "rdoEmployee";
            rdoEmployee.Size = new Size(211, 52);
            rdoEmployee.TabIndex = 3;
            rdoEmployee.TabStop = true;
            rdoEmployee.Text = "Nhân viên";
            rdoEmployee.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(932, 652);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(680, 63);
            txtConfirmPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(932, 528);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(680, 63);
            txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(927, 401);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(680, 63);
            txtEmail.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(927, 276);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(680, 63);
            txtFullName.TabIndex = 2;
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new Point(927, 146);
            txtStaffId.Multiline = true;
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(680, 63);
            txtStaffId.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(560, 932);
            label8.Name = "label8";
            label8.Size = new Size(185, 48);
            label8.TabIndex = 1;
            label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(560, 806);
            label7.Name = "label7";
            label7.Size = new Size(130, 48);
            label7.TabIndex = 1;
            label7.Text = "Vai trò:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(560, 667);
            label6.Name = "label6";
            label6.Size = new Size(329, 48);
            label6.TabIndex = 1;
            label6.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(560, 534);
            label5.Name = "label5";
            label5.Size = new Size(176, 48);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(555, 411);
            label4.Name = "label4";
            label4.Size = new Size(113, 48);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(555, 268);
            label3.Name = "label3";
            label3.Size = new Size(181, 48);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(555, 147);
            label2.Name = "label2";
            label2.Size = new Size(241, 48);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(955, 36);
            label1.Name = "label1";
            label1.Size = new Size(335, 72);
            label1.TabIndex = 0;
            label1.Text = "NHÂN VIÊN";
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dgvStaff);
            tabPageList.Location = new Point(10, 55);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(2246, 1343);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "   DANH SÁCH";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(-10, 6);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 92;
            dgvStaff.Size = new Size(2250, 1336);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellClick += dgvStaff_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoManager);
            groupBox1.Controls.Add(rdoEmployee);
            groupBox1.Location = new Point(905, 775);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 109);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoActive);
            groupBox2.Controls.Add(rdoInactive);
            groupBox2.Location = new Point(903, 890);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(709, 112);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(tabControl);
            Name = "frmStaff";
            Text = "Quản Lý Nhân Viên";
            tabControl.ResumeLayout(false);
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageUpdate;
        private TabPage tabPageList;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtStaffId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button btnAdd;
        private RadioButton rdoEmployee;
        private Label label7;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private RadioButton rdoManager;
        private DataGridView dgvStaff;
        private RadioButton rdoInactive;
        private RadioButton rdoActive;
        private Label label8;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}