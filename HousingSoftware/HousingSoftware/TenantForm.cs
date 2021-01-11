using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingSoftware
{
    public partial class TenantForm : Form
    {
        Agreements newAgreement;
        int indexCurrTenant;

        //LoginForm LoginForm;
        List<Admin> admins;
        int indexCurrAdmin;
        public TenantForm(int indexCurrTenant, int indexCurrAdmin, List<Admin> admins)
        {
            InitializeComponent();
            this.admins = admins;
            this.indexCurrAdmin = indexCurrAdmin;
            this.indexCurrTenant = indexCurrTenant;
        }



        // Show unpaid Groceries
        private void showUnpaidGroceries(ListBox unpaidGroceries, int index)
        {
            unpaidGroceries.Items.Clear();
            List<Grocery> groceries = admins[indexCurrAdmin].Tenants[index].GroceriesTenant;
            foreach (Grocery grocery in groceries)
            {
                unpaidGroceries.Items.Add(grocery.GetInfo());
            }
        }

        private void TenantForm_Load(object sender, EventArgs e)
        {
            WelcomeMessageTenant();

            showUnpaidGroceries(lbxUnpaidGroceries, indexCurrTenant);

            // Refresh the listbox containing all agreements
            RefreshAgreementsTenant();
            // Refresh house rules for teanents
            refreshHouseRulesTeanent();
            // Refresh announcements for teanents
            refreshAnnouncementsTeanent();


            timerTenant.Enabled = true;

            lbTimeTenant.Text = DateTime.Now.ToString("HH:mm");
            lblDateTenant.Text = DateTime.Now.ToString("dddd, MMMM dd");

            // Clear default text for the label for groceries notifications
            lblUnpaidGroceriesNotification.Text = "";

            if (lbxUnpaidGroceries.Items.Count > 0)
            {
                if (lbxUnpaidGroceries.Items.Count == 1)
                {
                    lblUnpaidGroceriesNotification.Text = $"There is {lbxUnpaidGroceries.Items.Count} grocery item to pay for.";
                }
                else
                {
                    lblUnpaidGroceriesNotification.Text = $"There are {lbxUnpaidGroceries.Items.Count} grocery items to pay for.";

                }

                lblUnpaidGroceriesNotification.BackColor = Color.Yellow;
            }

        }

        private void WelcomeMessageTenant()
        {
            string time = DateTime.Now.ToString("HH");

            if (time.StartsWith("0"))
            {
                time.Remove(0, 1);
            }

            int currentTime = Convert.ToInt32(time);

            if (currentTime >= 5 && currentTime < 12)
            {
                lbWelcomeMsgTenant.Text = $"Good morning, {admins[indexCurrAdmin].Tenants[indexCurrTenant].FirstName}!";
            }
            else if (currentTime >= 12 && currentTime < 17)
            {
                lbWelcomeMsgTenant.Text = $"Have a good afternoon, {admins[indexCurrAdmin].Tenants[indexCurrTenant].FirstName}";
            }
            else if (currentTime >= 17 && currentTime < 21)
            {
                lbWelcomeMsgTenant.Text = $"Have a nice evening, {admins[indexCurrAdmin].Tenants[indexCurrTenant].FirstName}!";
            }
            else
            {
                lbWelcomeMsgTenant.Text = $"Good night, {admins[indexCurrAdmin].Tenants[indexCurrTenant].FirstName}";
            }

        }

        private void btnLogOutTenant_Click(object sender, EventArgs e)
        {
            timerTenant.Enabled = false;
            this.Close();
        }

        //AGREEMENTS

        private void btnAddAgreement_Click(object sender, EventArgs e) // Add new agreement
        {
            string agreement = tbxAddAgreement.Text;

            if (FindAgreementIndex(agreement) != -1)
            {
                MessageBox.Show($"This agreement already exists.");
            }
            else
            {
                if (tbxAddAgreement.Text != "" && tbxAddAgreement.Text.Length > 20)
                {
                    newAgreement = new Agreements();
                    admins[indexCurrAdmin].AddAgreement(newAgreement);
                    newAgreement.AddNewAgreement(agreement);
                    tbxAddAgreement.Clear();

                    RefreshAgreementsTenant();

                    MessageBox.Show($"Your agreement has been added.");

                }
                else
                {
                    MessageBox.Show("Please, make sure to enter a text containing 20 more charachters.");
                }
            }

        }

        private void RefreshAgreementsTenant() // Refreshes the listbox showing all agreements
        {
            lbxAllAgreementsTenant.Items.Clear();

            foreach (Agreements agreement in admins[indexCurrAdmin].Agreements)
            {
                lbxAllAgreementsTenant.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
            }
        }


        private void SearchAgreementsTenant(string searchText) // Search all agreements based on string input
        {
            lbxAllAgreementsTenant.Items.Clear();

            foreach (Agreements agreement in admins[indexCurrAdmin].Agreements)
            {
                if (agreement.GetAgreement().Contains(searchText))
                {
                    lbxAllAgreementsTenant.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
                }
            }
        }

        private void btnSearchAgreement_Click(object sender, EventArgs e) // Search all agreements based on string input
        {
            SearchAgreementsTenant(tbxSearchAgreementsTenant.Text);
        }

        private void btnShowAllAgreements_Click(object sender, EventArgs e) // Show all agreements (can be used after searching)
        {
            RefreshAgreementsTenant();
        }

        private bool hasVoted(Agreements selectedAgreement, int studentNr) // Checks if the currently logged tenant has voted for the selected agreements
        {

            if (selectedAgreement.GetAgreed().Contains(studentNr) || selectedAgreement.GetDisagreed().Contains(studentNr))
            {
                MessageBox.Show("You have already voted for the selected agreement.");
                return true;
            }

            return false;
        }


        private int FindAgreementIndex(string agreementText) // Finds the index in the list of the selected agreeemtnt
        {
            foreach (Agreements agreement in admins[indexCurrAdmin].Agreements)
            {
                if (agreement.GetAgreement() == agreementText)
                {
                    return admins[indexCurrAdmin].Agreements.IndexOf(agreement);
                }
            }
            return -1;
        }

        private void AgreeDisagree(char choice) // The currently logged tenant votes for a selected agreements
        {
            if (lbxAllAgreementsTenant.SelectedIndex == -1)
            {
                MessageBox.Show("In order to Agree/Disagree, please, make sure to select an existing agreement from the list.");
            }
            else
            {
                //get the student number of the currently logged tennants
                Tenant currentTenant = admins[indexCurrAdmin].Tenants[indexCurrTenant];

                string agreement = lbxAllAgreementsTenant.SelectedItem.ToString();
                int stNumber = Convert.ToInt32(currentTenant.StudentNumber);

                //select
                string selectedAgreement = lbxAllAgreementsTenant.SelectedItem.ToString().Split(':')[1];
                selectedAgreement = selectedAgreement.Remove(0, 1);
                int index = FindAgreementIndex(selectedAgreement);

                if (!hasVoted(admins[indexCurrAdmin].Agreements[index], stNumber))
                {
                    if (choice == 'a')
                    {
                        admins[indexCurrAdmin].Agreements[index].Agree(stNumber);
                    }
                    else if (choice == 'd')
                    {
                        admins[indexCurrAdmin].Agreements[index].Disagree(stNumber);
                    }

                }
                RefreshAgreementsTenant();
            }
        }

        private void btnAgree_Click(object sender, EventArgs e) // Agree
        {
            AgreeDisagree('a');
        }

        private void btnDisagree_Click(object sender, EventArgs e) // Disagree
        {
            AgreeDisagree('d');
        }

        //COMPLAINTS
        private void btnComplaint_Click(object sender, EventArgs e) // Send an anonymous complaint to the admin
        {
            if (!String.IsNullOrEmpty(tbxWriteComplaint.Text))
            {
                admins[indexCurrAdmin].AddComplaint($"{DateTime.Now.ToString("MMMM dd, yyyy")}: {tbxWriteComplaint.Text}");
                tbxWriteComplaint.Clear();
                MessageBox.Show("Your complaint has been sent to Student Housing BV.");
            }
            else
            {
                MessageBox.Show("In order to send a complaint, please, enter a text in the text box.");
            }
        }

        private void timerTenant_Tick(object sender, EventArgs e)
        {
            WelcomeMessageTenant();

            if (lblUnpaidGroceriesNotification.BackColor == Color.Yellow)
            {
                lblUnpaidGroceriesNotification.BackColor = Color.Red;
            }
            else if (lblUnpaidGroceriesNotification.BackColor == Color.Red)
            {
                lblUnpaidGroceriesNotification.BackColor = Color.Yellow;
            }

            lbTimeTenant.Text = DateTime.Now.ToString("HH:mm");
            lblDateTenant.Text = DateTime.Now.ToString("dddd, MMMM dd");
        }

        private void lblUnpaidGroceriesNotification_Click(object sender, EventArgs e)
        {
            MenuTenant.SelectedIndex = 1;
        }
        // refresh house rules method
        private void refreshHouseRulesTeanent()
        {

            lbxRulesTenant.Items.Clear();
            foreach (HouseRules rule in admins[indexCurrAdmin].HouseRules)
            {
                lbxRulesTenant.Items.Add(rule.HouseRule);
            }

        }
        private void refreshAnnouncementsTeanent()
        {
            lbxUserAllAnnouncements.Items.Clear();
            foreach (Announcements announcement in admins[indexCurrAdmin].Announcements)
            {
                lbxUserAllAnnouncements.Items.Add(announcement.Announcement);
            }
        }

        private void TenantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(admins);
            loginForm.Show();
        }
    }
}
