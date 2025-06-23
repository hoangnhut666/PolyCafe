namespace GUI_UI_PolyCafe
{
    partial class frmProductCategories
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
            txtNotes = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageList = new TabPage();
            dgvProductCategories = new DataGridView();
            tabControl.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductCategories).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageUpdate);
            tabControl.Controls.Add(tabPageList);
            tabControl.Location = new Point(1, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(2259, 1409);
            tabControl.TabIndex = 0;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(btnRefresh);
            tabPageUpdate.Controls.Add(btnDelete);
            tabPageUpdate.Controls.Add(btnUpdate);
            tabPageUpdate.Controls.Add(btnAdd);
            tabPageUpdate.Controls.Add(txtNotes);
            tabPageUpdate.Controls.Add(txtCategoryName);
            tabPageUpdate.Controls.Add(txtCategoryId);
            tabPageUpdate.Controls.Add(label4);
            tabPageUpdate.Controls.Add(label3);
            tabPageUpdate.Controls.Add(label2);
            tabPageUpdate.Controls.Add(label1);
            tabPageUpdate.Location = new Point(10, 55);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(2239, 1344);
            tabPageUpdate.TabIndex = 0;
            tabPageUpdate.Text = "CẬP NHẬT  ";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(162, 192, 248);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.Location = new Point(1526, 895);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(226, 72);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(162, 192, 248);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.Location = new Point(1180, 895);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(226, 72);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(162, 192, 248);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.Location = new Point(821, 895);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 72);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(162, 192, 248);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.Location = new Point(462, 895);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(226, 72);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(821, 529);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(797, 226);
            txtNotes.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(821, 371);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(797, 69);
            txtCategoryName.TabIndex = 2;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(821, 223);
            txtCategoryId.Multiline = true;
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(797, 69);
            txtCategoryId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(573, 544);
            label4.Name = "label4";
            label4.Size = new Size(139, 45);
            label4.TabIndex = 1;
            label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(573, 386);
            label3.Name = "label3";
            label3.Size = new Size(138, 45);
            label3.TabIndex = 1;
            label3.Text = "Tên loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(573, 238);
            label2.Name = "label2";
            label2.Size = new Size(135, 45);
            label2.TabIndex = 1;
            label2.Text = "Mã loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(890, 52);
            label1.Name = "label1";
            label1.Size = new Size(458, 72);
            label1.TabIndex = 0;
            label1.Text = "LOẠI SẢN PHẨM";
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dgvProductCategories);
            tabPageList.Location = new Point(10, 55);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(2239, 1344);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "DANH SÁCH  ";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dgvProductCategories
            // 
            dgvProductCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductCategories.Location = new Point(6, 6);
            dgvProductCategories.Name = "dgvProductCategories";
            dgvProductCategories.RowHeadersWidth = 92;
            dgvProductCategories.Size = new Size(2227, 1332);
            dgvProductCategories.TabIndex = 0;
            dgvProductCategories.CellClick += dgvProductCategories_CellClick;
            dgvProductCategories.DataBindingComplete += dgvProductCategories_DataBindingComplete;
            // 
            // frmProductCategories
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(tabControl);
            Name = "frmProductCategories";
            Text = "Quản lý loại sản phẩm";
            tabControl.ResumeLayout(false);
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageUpdate;
        private TabPage tabPageList;
        private TextBox txtCategoryId;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private TextBox txtNotes;
        private TextBox txtCategoryName;
        private Label label4;
        private Label label3;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgvProductCategories;
    }
}