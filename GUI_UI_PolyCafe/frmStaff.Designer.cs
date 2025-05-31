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
            tabControl1 = new TabControl();
            tabPageUpdate = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
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
            tabControl1.Location = new Point(3, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2266, 1408);
            tabControl1.TabIndex = 0;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(button4);
            tabPageUpdate.Controls.Add(button3);
            tabPageUpdate.Controls.Add(button2);
            tabPageUpdate.Controls.Add(button1);
            tabPageUpdate.Controls.Add(radioButton2);
            tabPageUpdate.Controls.Add(radioButton1);
            tabPageUpdate.Controls.Add(textBox5);
            tabPageUpdate.Controls.Add(textBox4);
            tabPageUpdate.Controls.Add(textBox3);
            tabPageUpdate.Controls.Add(textBox2);
            tabPageUpdate.Controls.Add(textBox1);
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
            // button4
            // 
            button4.BackColor = Color.FromArgb(162, 192, 248);
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(1454, 1062);
            button4.Name = "button4";
            button4.Size = new Size(197, 73);
            button4.TabIndex = 4;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(162, 192, 248);
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(1147, 1062);
            button3.Name = "button3";
            button3.Size = new Size(197, 73);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(162, 192, 248);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(821, 1062);
            button2.Name = "button2";
            button2.Size = new Size(197, 73);
            button2.TabIndex = 4;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(162, 192, 248);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(488, 1062);
            button1.Name = "button1";
            button1.Size = new Size(197, 73);
            button1.TabIndex = 4;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(1223, 954);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(172, 52);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Quản lý";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(927, 950);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(211, 52);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nhân viên";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(927, 798);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(680, 63);
            textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(927, 622);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(680, 63);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(927, 455);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(680, 63);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(927, 301);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(680, 63);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(927, 146);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(680, 63);
            textBox1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(555, 952);
            label7.Name = "label7";
            label7.Size = new Size(130, 48);
            label7.TabIndex = 1;
            label7.Text = "Vai trò:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(555, 813);
            label6.Name = "label6";
            label6.Size = new Size(329, 48);
            label6.TabIndex = 1;
            label6.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(555, 628);
            label5.Name = "label5";
            label5.Size = new Size(176, 48);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(555, 465);
            label4.Name = "label4";
            label4.Size = new Size(113, 48);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(555, 293);
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
            tabPageList.Controls.Add(dataGridView1);
            tabPageList.Location = new Point(10, 55);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(2246, 1343);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "   DANH SÁCH";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-10, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(2250, 1336);
            dataGridView1.TabIndex = 0;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1421);
            Controls.Add(tabControl1);
            Name = "frmStaff";
            Text = "Quản Lý Nhân Viên";
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
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button button1;
        private RadioButton radioButton1;
        private Label label7;
        private Button button4;
        private Button button3;
        private Button button2;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
    }
}