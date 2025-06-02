namespace GUI_UI_PolyCafe
{
    partial class frmAbout
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblContent1 = new Label();
            lblContent2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox1.Image = Properties.Resources._732_R1IgVklWIDMyMTUtMjE;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1201, 1425);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1590, 122);
            label1.Name = "label1";
            label1.Size = new Size(337, 72);
            label1.TabIndex = 1;
            label1.Text = "Về Poly Cafe";
            // 
            // lblContent1
            // 
            lblContent1.AutoSize = true;
            lblContent1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent1.ForeColor = SystemColors.ButtonHighlight;
            lblContent1.Location = new Point(1264, 306);
            lblContent1.Name = "lblContent1";
            lblContent1.Size = new Size(165, 48);
            lblContent1.TabIndex = 2;
            lblContent1.Text = "Content1";
            // 
            // lblContent2
            // 
            lblContent2.AutoSize = true;
            lblContent2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent2.ForeColor = SystemColors.ButtonHighlight;
            lblContent2.Location = new Point(1264, 663);
            lblContent2.Name = "lblContent2";
            lblContent2.Size = new Size(165, 48);
            lblContent2.TabIndex = 2;
            lblContent2.Text = "Content2";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(2272, 1421);
            Controls.Add(lblContent2);
            Controls.Add(lblContent1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmAbout";
            Text = "Giới thiệu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblContent1;
        private Label lblContent2;
    }
}