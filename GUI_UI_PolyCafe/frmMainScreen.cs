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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            timerClock.Start();
            timerClock.Tick += TimerClock_Tick;
            SetupComponent(dataGridView: null); 
        }


        private void SetupComponent(DataGridView? dataGridView)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
