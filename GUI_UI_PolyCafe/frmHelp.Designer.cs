﻿namespace GUI_UI_PolyCafe
{
    partial class frmHelp
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
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1191, 1425);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1603, 132);
            label1.Name = "label1";
            label1.Size = new Size(236, 72);
            label1.TabIndex = 4;
            label1.Text = "Trợ giúp";
            // 
            // lblContent1
            // 
            lblContent1.AutoSize = true;
            lblContent1.Font = new Font("Segoe UI", 11F);
            lblContent1.ForeColor = SystemColors.ButtonHighlight;
            lblContent1.Location = new Point(1264, 321);
            lblContent1.Name = "lblContent1";
            lblContent1.Size = new Size(154, 45);
            lblContent1.TabIndex = 5;
            lblContent1.Text = "Content1";
            // 
            // lblContent2
            // 
            lblContent2.AutoSize = true;
            lblContent2.Font = new Font("Segoe UI", 11F);
            lblContent2.ForeColor = SystemColors.ButtonHighlight;
            lblContent2.Location = new Point(1264, 671);
            lblContent2.Name = "lblContent2";
            lblContent2.Size = new Size(154, 45);
            lblContent2.TabIndex = 5;
            lblContent2.Text = "Content2";
            // 
            // frmHelp
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(2272, 1421);
            Controls.Add(lblContent2);
            Controls.Add(lblContent1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmHelp";
            Text = "Trợ giúp";
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