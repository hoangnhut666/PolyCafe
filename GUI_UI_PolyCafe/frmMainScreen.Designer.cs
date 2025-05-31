namespace GUI_UI_PolyCafe
{
    partial class frmMainScreen
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            itmChangePassword = new ToolStripMenuItem();
            itmExit = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            itmStaffManagement = new ToolStripMenuItem();
            itmMembershipCardManagement = new ToolStripMenuItem();
            itmProductCategoriesManagement = new ToolStripMenuItem();
            itmProductManagement = new ToolStripMenuItem();
            itmInvoiceManagement = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            itmRevenueByCategory = new ToolStripMenuItem();
            itmRevenueByStaff = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            itmHelp = new ToolStripMenuItem();
            itmAbout = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnExit = new ToolStripButton();
            btnStaffManagement = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            lblRole = new ToolStripLabel();
            lblAccount = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            lblSystemInfo = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            pnlMainContainer = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2272, 47);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itmChangePassword, itmExit });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(151, 43);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // itmChangePassword
            // 
            itmChangePassword.Image = Properties.Resources.arrows11;
            itmChangePassword.Name = "itmChangePassword";
            itmChangePassword.Size = new Size(403, 48);
            itmChangePassword.Text = "Đổi mật khẩu";
            itmChangePassword.Click += itmChangePassword_Click;
            // 
            // itmExit
            // 
            itmExit.Image = Properties.Resources.entry1;
            itmExit.Name = "itmExit";
            itmExit.Size = new Size(403, 48);
            itmExit.Text = "Đăng xuất";
            itmExit.Click += itmExit_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itmStaffManagement, itmMembershipCardManagement, itmProductCategoriesManagement, itmProductManagement, itmInvoiceManagement });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(130, 43);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // itmStaffManagement
            // 
            itmStaffManagement.Image = Properties.Resources.Female_user_search;
            itmStaffManagement.Name = "itmStaffManagement";
            itmStaffManagement.Size = new Size(451, 48);
            itmStaffManagement.Text = "Quản lý nhân viên";
            itmStaffManagement.Click += itmStaffManagement_Click;
            // 
            // itmMembershipCardManagement
            // 
            itmMembershipCardManagement.Image = Properties.Resources.user2;
            itmMembershipCardManagement.Name = "itmMembershipCardManagement";
            itmMembershipCardManagement.Size = new Size(451, 48);
            itmMembershipCardManagement.Text = "Quản lý khách hàng";
            itmMembershipCardManagement.Click += itmMembershipCardManagement_Click;
            // 
            // itmProductCategoriesManagement
            // 
            itmProductCategoriesManagement.Image = Properties.Resources.Packing1;
            itmProductCategoriesManagement.Name = "itmProductCategoriesManagement";
            itmProductCategoriesManagement.Size = new Size(451, 48);
            itmProductCategoriesManagement.Text = "Quản lý loại sản phẩm";
            itmProductCategoriesManagement.Click += itmProductCategoriesManagement_Click;
            // 
            // itmProductManagement
            // 
            itmProductManagement.Image = Properties.Resources.coffee1;
            itmProductManagement.Name = "itmProductManagement";
            itmProductManagement.Size = new Size(451, 48);
            itmProductManagement.Text = "Quản lý sản phẩm";
            itmProductManagement.Click += itmProductManagement_Click;
            // 
            // itmInvoiceManagement
            // 
            itmInvoiceManagement.Image = Properties.Resources.Product_sale_report;
            itmInvoiceManagement.Name = "itmInvoiceManagement";
            itmInvoiceManagement.Size = new Size(451, 48);
            itmInvoiceManagement.Text = "Quản lý phiếu bán hàng";
            itmInvoiceManagement.Click += itmInvoiceManagement_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itmRevenueByCategory, itmRevenueByStaff });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(149, 43);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // itmRevenueByCategory
            // 
            itmRevenueByCategory.Image = Properties.Resources.Order_history1;
            itmRevenueByCategory.Name = "itmRevenueByCategory";
            itmRevenueByCategory.Size = new Size(526, 48);
            itmRevenueByCategory.Text = "Doanh thu theo loại sản phẩm";
            // 
            // itmRevenueByStaff
            // 
            itmRevenueByStaff.Image = Properties.Resources.Sales_by_payment_method;
            itmRevenueByStaff.Name = "itmRevenueByStaff";
            itmRevenueByStaff.Size = new Size(526, 48);
            itmRevenueByStaff.Text = "Danh thu theo nhân viên";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itmHelp, itmAbout });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(115, 43);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // itmHelp
            // 
            itmHelp.Image = Properties.Resources.Select_language;
            itmHelp.Name = "itmHelp";
            itmHelp.Size = new Size(403, 48);
            itmHelp.Text = "Trợ giúp";
            itmHelp.Click += itmHelp_Click;
            // 
            // itmAbout
            // 
            itmAbout.Image = Properties.Resources.information1;
            itmAbout.Name = "itmAbout";
            itmAbout.Size = new Size(403, 48);
            itmAbout.Text = "Giới thiệu";
            itmAbout.Click += itmAbout_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(36, 36);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnExit, btnStaffManagement, toolStripButton3, toolStripButton4, toolStripButton5, lblRole, lblAccount });
            toolStrip1.Location = new Point(0, 47);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(2272, 46);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = Properties.Resources.entry;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(52, 40);
            btnExit.Text = "toolStripButton1";
            btnExit.Click += btnExit_Click;
            // 
            // btnStaffManagement
            // 
            btnStaffManagement.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStaffManagement.Image = Properties.Resources.users;
            btnStaffManagement.ImageTransparentColor = Color.Magenta;
            btnStaffManagement.Name = "btnStaffManagement";
            btnStaffManagement.Size = new Size(52, 40);
            btnStaffManagement.Text = "toolStripButton2";
            btnStaffManagement.Click += btnStaffManagement_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.Order_history;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(52, 40);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.coffee;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(52, 40);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.information;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(52, 40);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // lblRole
            // 
            lblRole.Alignment = ToolStripItemAlignment.Right;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(140, 40);
            lblRole.Text = "Admin      ";
            // 
            // lblAccount
            // 
            lblAccount.Alignment = ToolStripItemAlignment.Right;
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(139, 40);
            lblAccount.Text = "Chào bạn!";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(36, 36);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSystemInfo, toolStripStatusLabel2, lblClock });
            statusStrip1.Location = new Point(0, 1373);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2272, 48);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSystemInfo
            // 
            lblSystemInfo.Image = Properties.Resources.fpt;
            lblSystemInfo.Name = "lblSystemInfo";
            lblSystemInfo.Size = new Size(368, 37);
            lblSystemInfo.Text = "Hệ thống quản lý PolyCafe";
            lblSystemInfo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1690, 37);
            toolStripStatusLabel2.Spring = true;
            // 
            // lblClock
            // 
            lblClock.Image = Properties.Resources.Alarm_clock;
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(199, 37);
            lblClock.Text = "CurrentTime";
            lblClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.Location = new Point(12, 94);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Size = new Size(2248, 1276);
            pnlMainContainer.TabIndex = 3;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(pnlMainContainer);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMainScreen";
            Text = "frmMainScreeen";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnExit;
        private ToolStripButton btnStaffManagement;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripLabel lblRole;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSystemInfo;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timerClock;
        private ToolStripStatusLabel lblClock;
        private Panel pnlMainContainer;
        private ToolStripLabel lblAccount;
        private ToolStripMenuItem itmStaffManagement;
        private ToolStripMenuItem itmMembershipCardManagement;
        private ToolStripMenuItem itmProductCategoriesManagement;
        private ToolStripMenuItem itmProductManagement;
        private ToolStripMenuItem itmInvoiceManagement;
        private ToolStripMenuItem itmChangePassword;
        private ToolStripMenuItem itmExit;
        private ToolStripMenuItem itmRevenueByCategory;
        private ToolStripMenuItem itmRevenueByStaff;
        private ToolStripMenuItem itmHelp;
        private ToolStripMenuItem itmAbout;
    }
}