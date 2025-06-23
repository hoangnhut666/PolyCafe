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
using DAL_Data_PolyCafe;
using DBUTIL_Utilities_PolyCafe;


namespace GUI_UI_PolyCafe
{
    public partial class frmMembershipCard : Form
    {
        public MembershipCardServices MembershipCardServices { get; set; }
        public frmMembershipCard()
        {
            MembershipCardServices = new MembershipCardServices();
            InitializeComponent();
            SetupComponent(dgvMembershipCards);
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading membership cards: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMembershipCards.DataSource = null;
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get a new membership card object with the data from the form fields 
                MembershipCard membershipCard = new MembershipCard
                {
                    CardId = MembershipCardServices.GenerateCardId(),
                    CardHolder = txtCardHolder.Text,
                    Status = chkStatus.Checked
                };

                // Add the membership card to the database  
                int result = MembershipCardServices.AddMembershipCard(membershipCard);
                if (result > 0)
                {
                    LoadAllMembershipCards();
                    tabControlMembershipCard.SelectedTab = tabPageListMembershipCards;
                    MessageBox.Show("Membership card added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add membership card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while adding the membership card. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected membership card form fields
                MembershipCard membershipCard = new MembershipCard
                {
                    CardId = txtCardId.Text,
                    CardHolder = txtCardHolder.Text,
                    Status = chkStatus.Checked
                };

                // Update the membership card in the database
                int result = MembershipCardServices.UpdateMembershipCard(membershipCard);
                if (result > 0)
                {
                    MessageBox.Show("Membership card updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllMembershipCards();
                }
                else
                {
                    MessageBox.Show("Failed to update membership card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                // Handle any exceptions that may occur during the update process
                MessageBox.Show("An error occurred while updating the membership card. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a membership card is selected
            if (txtCardId.Text == string.Empty)
            {
                MessageBox.Show("Please select a membership card to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this membership card?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                string cardId = txtCardId.Text;
                int result = MembershipCardServices.DeleteMembershipCard(cardId);
                if (result > 0)
                {
                    MessageBox.Show("Membership card deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllMembershipCards();
                    btnRefresh.PerformClick();
                }
                else
                {
                    MessageBox.Show("Failed to delete membership card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while deleting the membership card. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCardId.Clear();
            txtCardHolder.Clear();
            chkStatus.Checked = false;
        }


        private void dgvMembershipCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected membership card
            if (dgvMembershipCards.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMembershipCards.SelectedRows[0];
                MembershipCard selectedCard = (MembershipCard)selectedRow.DataBoundItem;

                // Fill the controls with the selected membership card's data
                txtCardId.Text = selectedCard.CardId;
                txtCardHolder.Text = selectedCard.CardHolder;
                chkStatus.Checked = selectedCard.Status;

                //Direct to the update section tab
                tabControlMembershipCard.SelectedTab = tabPageUpdate;
            }
            else
            {
                txtCardId.Clear();
                txtCardHolder.Clear();
                chkStatus.Checked = false;
            }
        }

        private void frmMembershipCard_Load(object sender, EventArgs e)
        {
            if (!AuthUtil.IsManager())
            {
                tabControlMembershipCard.TabPages.Remove(tabPageUpdate);
            }
        }

        private void dgvMembershipCards_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMembershipCards.Columns["CardId"].HeaderText = "Mã Thẻ";
            dgvMembershipCards.Columns["CardHolder"].HeaderText = "Chủ Sở Hữu";  
            dgvMembershipCards.Columns["Status"].HeaderText = "Trạng Thái";
        }
    }
}

















































//Get the selected staff member
//if (staffDataGridView.SelectedRows.Count > 0)
//{
//    DataGridViewRow selectedRow = staffDataGridView.SelectedRows[0];
//    Staff selectedStaff = (Staff)selectedRow.DataBoundItem;

//    //Fill the controls with the selected staff member's data
//    staffIdTextBox.Text = selectedStaff.StaffId.ToString();
//    fullNameStaffTextBox.Text = selectedStaff.Name;
//    roleIdStaffTabTextBox.Text = selectedStaff.Role;
//    phoneNumberStaffTabTextBox.Text = selectedStaff.Phone;
//    usenameStaffTextBox.Text = selectedStaff.Username;
//    passwordStaffTabTextBox.Text = selectedStaff.Password;
//}




//if (dgvMembershipCards.SelectedRows.Count > 0)
//{
//    var selectedRow = dgvMembershipCards.SelectedRows[0];
//    MembershipCard membershipCard = new MembershipCard
//    {
//        CardId = selectedRow.Cells["CardId"].Value.ToString(),
//        CardHolder = txtCardHolder.Text,
//        Status = chkStatus.Checked
//    };

//    // Update the membership card in the database
//    int result = MembershipCardServices.UpdateMembershipCard(membershipCard);
//    if (result > 0)
//    {
//        MessageBox.Show("Membership card updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        LoadAllMembershipCards();
//    }
//    else
//    {
//        MessageBox.Show("Failed to update membership card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}
//else
//{
//    MessageBox.Show("Please select a membership card to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//}


//Check if the staff information is valid before adding or updating
//private bool IsValidMembershipCard()
//{
//    if (string.IsNullOrWhiteSpace(txtCardHolder.Text))
//    {
//        MessageBox.Show("Please enter the card holder's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        return false;
//    }
//    return true;
//}