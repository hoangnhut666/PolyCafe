namespace GUI_UI_PolyCafe
{
    partial class MembershipCard
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
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            txtCardId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageListMembershipCards = new TabPage();
            dgvMembershipCards = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            tabPageListMembershipCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembershipCards).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUpdate);
            tabControl1.Controls.Add(tabPageListMembershipCards);
            tabControl1.Location = new Point(0, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2260, 1409);
            tabControl1.TabIndex = 0;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(btnRefresh);
            tabPageUpdate.Controls.Add(btnDelete);
            tabPageUpdate.Controls.Add(btnUpdate);
            tabPageUpdate.Controls.Add(btnAdd);
            tabPageUpdate.Controls.Add(checkBox1);
            tabPageUpdate.Controls.Add(textBox1);
            tabPageUpdate.Controls.Add(txtCardId);
            tabPageUpdate.Controls.Add(label4);
            tabPageUpdate.Controls.Add(label3);
            tabPageUpdate.Controls.Add(label2);
            tabPageUpdate.Controls.Add(label1);
            tabPageUpdate.Location = new Point(10, 55);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(2240, 1344);
            tabPageUpdate.TabIndex = 0;
            tabPageUpdate.Text = "CẬP NHẬT ";
            tabPageUpdate.UseVisualStyleBackColor = true;
     
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Cyan;
            btnRefresh.Location = new Point(1451, 729);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(222, 82);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(1161, 729);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(222, 82);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.LightSalmon;
            btnUpdate.Location = new Point(867, 729);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(222, 82);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(572, 729);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(222, 82);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11F);
            checkBox1.Location = new Point(953, 528);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(207, 49);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Hoạt động";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(953, 384);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(652, 74);
            textBox1.TabIndex = 2;
            // 
            // txtCardId
            // 
            txtCardId.Font = new Font("Segoe UI", 11F);
            txtCardId.Location = new Point(953, 260);
            txtCardId.Multiline = true;
            txtCardId.Name = "txtCardId";
            txtCardId.Size = new Size(652, 69);
            txtCardId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(633, 532);
            label4.Name = "label4";
            label4.Size = new Size(171, 45);
            label4.TabIndex = 1;
            label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(633, 390);
            label3.Name = "label3";
            label3.Size = new Size(195, 45);
            label3.TabIndex = 1;
            label3.Text = "Chủ Sở Hữu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(633, 266);
            label2.Name = "label2";
            label2.Size = new Size(136, 45);
            label2.TabIndex = 1;
            label2.Text = "Mã Thẻ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(923, 102);
            label1.Name = "label1";
            label1.Size = new Size(433, 72);
            label1.TabIndex = 0;
            label1.Text = "THẺ LƯU ĐỘNG";
     
            // 
            // tabPageListMembershipCards
            // 
            tabPageListMembershipCards.Controls.Add(dgvMembershipCards);
            tabPageListMembershipCards.Location = new Point(10, 55);
            tabPageListMembershipCards.Name = "tabPageListMembershipCards";
            tabPageListMembershipCards.Padding = new Padding(3);
            tabPageListMembershipCards.Size = new Size(2240, 1344);
            tabPageListMembershipCards.TabIndex = 1;
            tabPageListMembershipCards.Text = "DANH SÁCH";
            tabPageListMembershipCards.UseVisualStyleBackColor = true;
            // 
            // dgvMembershipCards
            // 
            dgvMembershipCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembershipCards.Location = new Point(0, 6);
            dgvMembershipCards.Name = "dgvMembershipCards";
            dgvMembershipCards.RowHeadersWidth = 92;
            dgvMembershipCards.Size = new Size(2234, 1332);
            dgvMembershipCards.TabIndex = 0;
            dgvMembershipCards.CellClick += dgvMembershipCards_CellClick;
            // 
            // MembershipCard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(tabControl1);
            Name = "MembershipCard";
            Text = "MembershipCard";
            tabControl1.ResumeLayout(false);
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            tabPageListMembershipCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembershipCards).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageUpdate;
        private TabPage tabPageListMembershipCards;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox txtCardId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvMembershipCards;
    }
}