using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Services_PolyCafe;
using DTO_Models_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class MembershipCard : Form
    {
        public MembershipCardServices MembershipCardServices { get; set; }
        public MembershipCard()
        {
            InitializeComponent();
            SetupComponent(dgvMembershipCards);
            MembershipCardServices = new MembershipCardServices();
            LoadAllMembershipCards();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void LoadAllMembershipCards()
        {
            var membershipCards = MembershipCardServices.GetAllMembershipCards();
            if (membershipCards != null && membershipCards.Count > 0)
            {
                dgvMembershipCards.DataSource = membershipCards;
            }
            else
            {
                MessageBox.Show("No membership cards found.");
                dgvMembershipCards.DataSource = null;
            }
        }

        private void dgvMembershipCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
