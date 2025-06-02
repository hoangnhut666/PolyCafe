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
            tabControl1 = new TabControl();
            tabPageUpdate = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageList = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUpdate);
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Location = new Point(1, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2259, 1409);
            tabControl1.TabIndex = 0;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(button4);
            tabPageUpdate.Controls.Add(button3);
            tabPageUpdate.Controls.Add(button2);
            tabPageUpdate.Controls.Add(button1);
            tabPageUpdate.Controls.Add(textBox3);
            tabPageUpdate.Controls.Add(textBox2);
            tabPageUpdate.Controls.Add(textBox1);
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
            // button4
            // 
            button4.BackColor = Color.FromArgb(162, 192, 248);
            button4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button4.Location = new Point(1526, 895);
            button4.Name = "button4";
            button4.Size = new Size(226, 72);
            button4.TabIndex = 3;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(162, 192, 248);
            button3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button3.Location = new Point(1180, 895);
            button3.Name = "button3";
            button3.Size = new Size(226, 72);
            button3.TabIndex = 3;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(162, 192, 248);
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button2.Location = new Point(821, 895);
            button2.Name = "button2";
            button2.Size = new Size(226, 72);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(162, 192, 248);
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button1.Location = new Point(462, 895);
            button1.Name = "button1";
            button1.Size = new Size(226, 72);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(821, 529);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(797, 226);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(821, 371);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(797, 69);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(821, 223);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(797, 69);
            textBox1.TabIndex = 2;
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
            tabPageList.Controls.Add(dataGridView1);
            tabPageList.Location = new Point(10, 55);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(2239, 1344);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "DANH SÁCH  ";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(2227, 1332);
            dataGridView1.TabIndex = 0;
            // 
            // frmProductCategories
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(tabControl1);
            Name = "frmProductCategories";
            Text = "Quản lý loại sản phẩm";
            tabControl1.ResumeLayout(false);
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageUpdate;
        private TabPage tabPageList;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}