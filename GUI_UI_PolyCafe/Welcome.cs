using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_UI_PolyCafe
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            SetupComponent();

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            Task.Delay(3000).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    this.Dispose();
                }));
            });
        }


        private void SetupComponent()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Prevent the form from closing by user clicking the close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MessageBox.Show("Please wait for the application to load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}