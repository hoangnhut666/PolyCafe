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
            rdoManager = new RadioButton();
            chk_active = new CheckBox();
            rdoEmployee = new RadioButton();
            chk_displayConfirmPassword = new CheckBox();
            chk_displayPassword = new CheckBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
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
            tabControl.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
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
            tabPageUpdate.Controls.Add(rdoManager);
            tabPageUpdate.Controls.Add(chk_active);
            tabPageUpdate.Controls.Add(rdoEmployee);
            tabPageUpdate.Controls.Add(chk_displayConfirmPassword);
            tabPageUpdate.Controls.Add(chk_displayPassword);
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
            tabPageUpdate.Font = new Font("Segoe UI", 11F);
            tabPageUpdate.Location = new Point(10, 55);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(2246, 1343);
            tabPageUpdate.TabIndex = 0;
            tabPageUpdate.Text = "CẬP NHẬT";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // rdoManager
            // 
            rdoManager.AutoSize = true;
            rdoManager.Font = new Font("Segoe UI", 12F);
            rdoManager.Location = new Point(1857, 577);
            rdoManager.Name = "rdoManager";
            rdoManager.Size = new Size(172, 52);
            rdoManager.TabIndex = 3;
            rdoManager.TabStop = true;
            rdoManager.Text = "Quản lý";
            rdoManager.UseVisualStyleBackColor = true;
            // 
            // chk_active
            // 
            chk_active.AutoSize = true;
            chk_active.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_active.Location = new Point(525, 749);
            chk_active.Name = "chk_active";
            chk_active.Size = new Size(207, 49);
            chk_active.TabIndex = 8;
            chk_active.Text = "Hoạt động";
            chk_active.UseVisualStyleBackColor = true;
            // 
            // rdoEmployee
            // 
            rdoEmployee.AutoSize = true;
            rdoEmployee.Font = new Font("Segoe UI", 12F);
            rdoEmployee.Location = new Point(1493, 577);
            rdoEmployee.Name = "rdoEmployee";
            rdoEmployee.Size = new Size(211, 52);
            rdoEmployee.TabIndex = 3;
            rdoEmployee.TabStop = true;
            rdoEmployee.Text = "Nhân viên";
            rdoEmployee.UseVisualStyleBackColor = true;
            // 
            // chk_displayConfirmPassword
            // 
            chk_displayConfirmPassword.AutoSize = true;
            chk_displayConfirmPassword.Location = new Point(1494, 459);
            chk_displayConfirmPassword.Name = "chk_displayConfirmPassword";
            chk_displayConfirmPassword.Size = new Size(264, 49);
            chk_displayConfirmPassword.TabIndex = 7;
            chk_displayConfirmPassword.Text = "Hiện mật khẩu";
            chk_displayConfirmPassword.UseVisualStyleBackColor = true;
            chk_displayConfirmPassword.CheckedChanged += chk_displayConfirmPassword_CheckedChanged;
            // 
            // chk_displayPassword
            // 
            chk_displayPassword.AutoSize = true;
            chk_displayPassword.Location = new Point(1494, 268);
            chk_displayPassword.Name = "chk_displayPassword";
            chk_displayPassword.Size = new Size(264, 49);
            chk_displayPassword.TabIndex = 7;
            chk_displayPassword.Text = "Hiện mật khẩu";
            chk_displayPassword.UseVisualStyleBackColor = true;
            chk_displayPassword.CheckedChanged += chk_displayPassword_CheckedChanged;
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
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(1494, 379);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(573, 51);
            txtConfirmPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(1494, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(575, 51);
            txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(521, 566);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(520, 63);
            txtEmail.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(521, 381);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(520, 63);
            txtFullName.TabIndex = 0;
            // 
            // txtStaffId
            // 
            txtStaffId.Font = new Font("Segoe UI", 11F);
            txtStaffId.Location = new Point(521, 190);
            txtStaffId.Multiline = true;
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(520, 63);
            txtStaffId.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(246, 747);
            label8.Name = "label8";
            label8.Size = new Size(185, 48);
            label8.TabIndex = 1;
            label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(1158, 577);
            label7.Name = "label7";
            label7.Size = new Size(130, 48);
            label7.TabIndex = 1;
            label7.Text = "Vai trò:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(1147, 381);
            label6.Name = "label6";
            label6.Size = new Size(329, 48);
            label6.TabIndex = 1;
            label6.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(1154, 197);
            label5.Name = "label5";
            label5.Size = new Size(176, 48);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(246, 566);
            label4.Name = "label4";
            label4.Size = new Size(113, 48);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(246, 373);
            label3.Name = "label3";
            label3.Size = new Size(181, 48);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(246, 191);
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
            dgvStaff.CellFormatting += dgvStaff_CellFormatting;
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
        private Label label8;
        private CheckBox chk_displayPassword;
        private CheckBox chk_displayConfirmPassword;
        private CheckBox chk_active;
    }
}