namespace GUI_UI_PolyCafe
{
    partial class Login
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
            txtUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnExitLoginPage = new Button();
            groupBox1 = new GroupBox();
            txtPassWord = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(676, 287);
            label1.Name = "label1";
            label1.Size = new Size(253, 48);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(676, 364);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Mã nhân viên";
            txtUserName.Size = new Size(729, 68);
            txtUserName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(840, 137);
            label2.Name = "label2";
            label2.Size = new Size(379, 81);
            label2.TabIndex = 0;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(676, 469);
            label3.Name = "label3";
            label3.Size = new Size(168, 48);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = SystemColors.ButtonHighlight;
            chkShowPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(676, 650);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(334, 52);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Hiển thị mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(676, 765);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(729, 102);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExitLoginPage
            // 
            btnExitLoginPage.BackColor = Color.IndianRed;
            btnExitLoginPage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExitLoginPage.ForeColor = SystemColors.ControlLightLight;
            btnExitLoginPage.Location = new Point(676, 909);
            btnExitLoginPage.Name = "btnExitLoginPage";
            btnExitLoginPage.Size = new Size(729, 102);
            btnExitLoginPage.TabIndex = 3;
            btnExitLoginPage.Text = "Thoát";
            btnExitLoginPage.UseVisualStyleBackColor = false;
            btnExitLoginPage.Click += btnExitLoginPage_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(txtPassWord);
            groupBox1.Location = new Point(504, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1068, 1134);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(172, 459);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(729, 43);
            txtPassWord.TabIndex = 0;
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2037, 1299);
            Controls.Add(btnExitLoginPage);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private Label label3;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnExitLoginPage;
        private GroupBox groupBox1;
        private TextBox txtPassWord;
    }
}