namespace GUI_UI_PolyCafe
{
    partial class frmChangePassword
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
            label1 = new Label();
            label2 = new Label();
            txtStaffId = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label4 = new Label();
            txtCurrentPassword = new TextBox();
            chkShowOldPassword = new CheckBox();
            label5 = new Label();
            txtNewPassword = new TextBox();
            chkShowNewPassword = new CheckBox();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            chkShowConfirmPassword = new CheckBox();
            btnSaveChanges = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(775, 65);
            label1.Name = "label1";
            label1.Size = new Size(433, 72);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(398, 207);
            label2.Name = "label2";
            label2.Size = new Size(219, 45);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // txtStaffId
            // 
            txtStaffId.Font = new Font("Segoe UI", 11F);
            txtStaffId.Location = new Point(717, 207);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new Size(859, 51);
            txtStaffId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(398, 314);
            label3.Name = "label3";
            label3.Size = new Size(222, 45);
            label3.TabIndex = 1;
            label3.Text = "Tên nhân viên";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(717, 314);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(859, 51);
            txtFullName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(398, 429);
            label4.Name = "label4";
            label4.Size = new Size(201, 45);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu cũ";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 11F);
            txtCurrentPassword.Location = new Point(717, 429);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(663, 51);
            txtCurrentPassword.TabIndex = 2;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // chkShowOldPassword
            // 
            chkShowOldPassword.AutoSize = true;
            chkShowOldPassword.Font = new Font("Segoe UI", 11F);
            chkShowOldPassword.Location = new Point(1434, 431);
            chkShowOldPassword.Name = "chkShowOldPassword";
            chkShowOldPassword.Size = new Size(166, 49);
            chkShowOldPassword.TabIndex = 3;
            chkShowOldPassword.Text = "Hiển thị";
            chkShowOldPassword.UseVisualStyleBackColor = true;
            chkShowOldPassword.CheckedChanged += chkShowCurrentPassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(398, 551);
            label5.Name = "label5";
            label5.Size = new Size(223, 45);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 11F);
            txtNewPassword.Location = new Point(717, 551);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(663, 51);
            txtNewPassword.TabIndex = 2;
            // 
            // chkShowNewPassword
            // 
            chkShowNewPassword.AutoSize = true;
            chkShowNewPassword.Font = new Font("Segoe UI", 11F);
            chkShowNewPassword.Location = new Point(1434, 553);
            chkShowNewPassword.Name = "chkShowNewPassword";
            chkShowNewPassword.Size = new Size(166, 49);
            chkShowNewPassword.TabIndex = 3;
            chkShowNewPassword.Text = "Hiển thị";
            chkShowNewPassword.UseVisualStyleBackColor = true;
            chkShowNewPassword.CheckedChanged += chkShowNewPassword_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(398, 676);
            label6.Name = "label6";
            label6.Size = new Size(299, 45);
            label6.TabIndex = 1;
            label6.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(717, 676);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(663, 51);
            txtConfirmPassword.TabIndex = 2;
            // 
            // chkShowConfirmPassword
            // 
            chkShowConfirmPassword.AutoSize = true;
            chkShowConfirmPassword.Font = new Font("Segoe UI", 11F);
            chkShowConfirmPassword.Location = new Point(1434, 678);
            chkShowConfirmPassword.Name = "chkShowConfirmPassword";
            chkShowConfirmPassword.Size = new Size(166, 49);
            chkShowConfirmPassword.TabIndex = 3;
            chkShowConfirmPassword.Text = "Hiển thị";
            chkShowConfirmPassword.UseVisualStyleBackColor = true;
            chkShowConfirmPassword.CheckedChanged += chkShowConfirmPassword_CheckedChanged;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new Font("Segoe UI", 11F);
            btnSaveChanges.Image = Properties.Resources.arrows1;
            btnSaveChanges.ImageAlign = ContentAlignment.TopCenter;
            btnSaveChanges.Location = new Point(749, 813);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(506, 140);
            btnSaveChanges.TabIndex = 4;
            btnSaveChanges.Text = "Đổi mật khẩu";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1972, 1221);
            Controls.Add(btnSaveChanges);
            Controls.Add(chkShowConfirmPassword);
            Controls.Add(chkShowNewPassword);
            Controls.Add(chkShowOldPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtStaffId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStaffId;
        private Label label3;
        private TextBox txtFullName;
        private Label label4;
        private TextBox txtCurrentPassword;
        private CheckBox chkShowOldPassword;
        private Label label5;
        private TextBox txtNewPassword;
        private CheckBox chkShowNewPassword;
        private Label label6;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowConfirmPassword;
        private Button btnSaveChanges;
    }
}