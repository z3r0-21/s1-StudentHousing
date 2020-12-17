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
        //private string adminUsername = "admin";
        //private string adminPassword = "admin";

        //Admin admin = new Admin("admin", "admin");
        Tenant currentTenant;
        Tenant tenant1;
        Announcements newannouncement;
        Agreements newAgreement;
        HouseRules newHouseRule;

        int indexCurrTenant;
        int indexTenantEdit;

        Grocery currentGrocery;

        //LoginForm LoginForm;
        Admin admin;
        int indexSearchedTenant = -1;
        public TenantForm(Admin admin, int indexCurrTenant)
        {
            InitializeComponent();
            this.admin = admin;
            this.indexCurrTenant = indexCurrTenant;
            //this.LoginForm = loginForm;
        }

        // Show unpaid Groceries
        private void showUnpaidGroceries(ListBox unpaidGroceries, int index)
        {
            //lbxUnpaidGroceries.Items.Clear();
            unpaidGroceries.Items.Clear();
            List<Grocery> groceries = admin.GetTenants()[index].GetGroceriesTenant();
            foreach (Grocery grocery in groceries)
            {
                //lbxUnpaidGroceries.Items.Add(grocery.GetInfo());
                unpaidGroceries.Items.Add(grocery.GetInfo());
            }
        }

        private void TenantForm_Load(object sender, EventArgs e)
        {
            //lbTime.Text = DateTime.Now.ToString("HH:mm");
            //lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd");

            lbWelcomeMsgTenant.Text = $"Welcome, {admin.GetTenants()[indexCurrTenant].GetFirstName()}";
            showUnpaidGroceries(lbxUnpaidGroceries, indexCurrTenant);

        }

        private void btnLogOutTenant_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(admin);
            loginForm.Show();
            this.Close();
        }


        //private void RefreshAgreements()
        //{
        //    lbxAllAgreementsTenant.Items.Clear();
        //    lbxAllAgreementsAdmin.Items.Clear();

        //    foreach (Agreements agreement in admin.GetAgreements())
        //    {
        //        lbxAllAgreementsTenant.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
        //        lbxAllAgreementsAdmin.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
        //    }
        //}

        //private void SearchAgreementsTenant(string searchText)
        //{
        //    lbxAllAgreementsTenant.Items.Clear();
        //    lbxAllAgreementsAdmin.Items.Clear();

        //    foreach (Agreements agreement in admin.GetAgreements())
        //    {
        //        if (agreement.GetAgreement().Contains(searchText))
        //        {
        //            lbxAllAgreementsTenant.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
        //        }
        //    }
        //}

        //private void SearchAgreementsAdmin(string searchText)
        //{
        //    lbxAllAgreementsTenant.Items.Clear();
        //    lbxAllAgreementsAdmin.Items.Clear();

        //    foreach (Agreements agreement in admin.GetAgreements())
        //    {
        //        if (agreement.GetAgreement().Contains(searchText))
        //        {
        //            lbxAllAgreementsAdmin.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
        //        }
        //    }
        //}




        //        private void btnComplaint_Click(object sender, EventArgs e)
        //        {
        //            if (!String.IsNullOrEmpty(tbxWriteComplaint.Text))
        //            {
        //                admin.AddComplaint($"{DateTime.Now.ToString("MMMM dd, yyyy")}: {tbxWriteComplaint.Text}");
        //                RefreshComplaintsList();
        //                tbxWriteComplaint.Clear();
        //                MessageBox.Show("Your complaint has been sent to Student Housing BV.");
        //            }
        //            else
        //            {
        //                MessageBox.Show("In order to send a complaint, please, enter a text in the text box.");
        //            }
        //        }

        //        private void btnMarkAsDone_Click(object sender, EventArgs e)
        //        {

        //            if (admin.GetComplaints().Count > 0 && lbxAllComplaints.SelectedIndex != -1)
        //            {
        //                admin.RemoveComplaint(lbxAllComplaints.SelectedItem.ToString());
        //                RefreshComplaintsList();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Please, make sure to select an item which you would like to be marked as done.");
        //            }
        //        }

        //        private void timerClock_Tick(object sender, EventArgs e)
        //        {
        //            lbTime.Text = DateTime.Now.ToString("HH:mm");
        //            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd");
        //        }

 

        //        private int FindAgreementIndex(string agreementText)
        //        {
        //            foreach (Agreements agreement in admin.GetAgreements())
        //            {
        //                if (agreement.GetAgreement() == agreementText)
        //                {
        //                    return admin.GetAgreements().IndexOf(agreement);
        //                }
        //            }
        //            return -1;
        //        }

        //        private bool hasVoted(Agreements selectedAgreement, int studentNr)
        //        {

        //            if (selectedAgreement.GetAgreed().Contains(studentNr) || selectedAgreement.GetDisagreed().Contains(studentNr))
        //            {
        //                MessageBox.Show("You have already voted for the selected agreement.");
        //                return true;
        //            }

        //            return false;
        //        }

        //        private void btnAddAgreement_Click(object sender, EventArgs e)
        //        {
        //            string agreement = tbxAddAgreement.Text;

        //            if (FindAgreementIndex(agreement) != -1)
        //            {
        //                MessageBox.Show($"This agreement already exists.");
        //            }
        //            else
        //            {
        //                if (tbxAddAgreement.Text != "" && tbxAddAgreement.Text.Length > 20)
        //                {
        //                    newAgreement = new Agreements();
        //                    admin.AddAgreement(newAgreement);
        //                    newAgreement.AddNewAgreement(agreement);
        //                    tbxAddAgreement.Clear();

        //                    RefreshAgreements();

        //                    MessageBox.Show($"Your agreement has been added.");

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Please, make sure to enter a text containing 20 more charachters.");
        //                }
        //            }

        //        }

        //        private void AgreeDisagree(char choice)
        //        {
        //            //get the student number of the currently logged tennants
        //            Tenant currentTenant = admin.GetTenants()[indexCurrTenant];

        //            string agreement = lbxAllAgreementsTenant.SelectedItem.ToString();
        //            int stNumber = Convert.ToInt32(currentTenant.GetStudentNumber());

        //            //select
        //            string selectedAgreement = lbxAllAgreementsTenant.SelectedItem.ToString().Split(':')[1];
        //            //selectedAgreement = selectedAgreement.TrimStart(' ');
        //            selectedAgreement = selectedAgreement.Remove(0, 1);
        //            int index = FindAgreementIndex(selectedAgreement);

        //            if (!hasVoted(admin.GetAgreements()[index], stNumber))
        //            {
        //                if (choice == 'a')
        //                {
        //                    admin.GetAgreements()[index].Agree(stNumber);
        //                }
        //                else if (choice == 'd')
        //                {
        //                    admin.GetAgreements()[index].Disagree(stNumber);
        //                }

        //            }
        //            RefreshAgreements();
        //        }

        //        private void btnAgree_Click(object sender, EventArgs e)
        //        {
        //            AgreeDisagree('a');
        //        }

        //        private void btnDisagree_Click(object sender, EventArgs e)
        //        {
        //            AgreeDisagree('d');
        //        }

        //        private void btnPostAnnouncement_Click(object sender, EventArgs e)
        //        {
        //            if (tbxPostAnnouncement.Text != "")
        //            {
        //                string announcement = tbxPostAnnouncement.Text;
        //                newannouncement = new Announcements(announcement);
        //                //newannouncement.AddAnnouncement(announcement);
        //                admin.AddAnnouncement(newannouncement);
        //                lbxAllAnnouncements.Items.Add($"{admin.GetUsername()}  -  {announcement}");
        //                lbxUserAllAnnouncements.Items.Add($"{admin.GetUsername()}  -  {announcement}");
        //            }
        //            else
        //            {
        //                MessageBox.Show($"Please, type something.");
        //            }
        //            tbxPostAnnouncement.Clear();
        //        }

        //        private void btndeleteAnnouncement_Click(object sender, EventArgs e)
        //        {
        //            int index = lbxAllAnnouncements.SelectedIndex;
        //            lbxAllAnnouncements.Items.RemoveAt(index);
        //        }



        //        private void btnSearchAgreement_Click(object sender, EventArgs e)
        //        {
        //            SearchAgreementsTenant(tbxSearchAgreementsTenant.Text);
        //        }

        //        private void btnShowAllAgreements_Click(object sender, EventArgs e)
        //        {
        //            RefreshAgreements();
        //        }

        //        private void btnSearchAgreementAdmin_Click(object sender, EventArgs e)
        //        {
        //            SearchAgreementsAdmin(tbxSearchAgreementsAdmin.Text);
        //        }

        //        private void btnShowAllAgreementsAdmin_Click(object sender, EventArgs e)
        //        {
        //            RefreshAgreements();
        //        }

        //        private void btnShowAllComplaints_Click(object sender, EventArgs e)
        //        {
        //            RefreshComplaintsList();
        //        }

        //        private void btnSearchComplaint_Click(object sender, EventArgs e)
        //        {
        //            SearchComplaints(tbxSearchComplaint.Text);
        //        }
        //        private void refreshHouseRules()
        //        {
        //            lbxRulesAdmin.Items.Clear();
        //            lbxRulesTenant.Items.Clear();
        //            foreach (HouseRules rule in admin.HouseRules)
        //            {
        //                lbxRulesAdmin.Items.Add(rule.HouseRule);
        //                lbxRulesTenant.Items.Add(rule.HouseRule);
        //            }

        //        }

        //        private void btnAddRule_Click(object sender, EventArgs e)
        //        {
        //            string rule = tbxAddRule.Text;
        //            newHouseRule = new HouseRules(rule);
        //            admin.AddHouseRule(newHouseRule);
        //            refreshHouseRules();
        //            tbxAddRule.Clear();
        //        }

        //        private void btnDeleteRule_Click(object sender, EventArgs e)
        //        {
        //            int index = lbxRulesAdmin.SelectedIndex;
        //            admin.HouseRules.RemoveAt(index);
        //            refreshHouseRules();

        //        }

        //        private void btnEditRule_Click(object sender, EventArgs e)
        //        {
        //            editBox.Visible = true;
        //            btnSaveEditedRule.Visible = true;
        //            int index = lbxRulesAdmin.SelectedIndex;
        //            string textToEdit = lbxRulesAdmin.Items[index].ToString();
        //            editBox.Text = textToEdit;
        //        }

        //        private void btnSaveEditedRule_Click(object sender, EventArgs e)
        //        {
        //            string rule = editBox.Text;
        //            newHouseRule = new HouseRules(rule);
        //            int index = lbxRulesAdmin.SelectedIndex;
        //            int indexTenant = index;
        //            lbxRulesAdmin.Items[index] = rule;
        //            admin.HouseRules[index] = newHouseRule;
        //            editBox.Visible = false;
        //            btnSaveEditedRule.Visible = false;
        //            refreshHouseRules();
        //            editBox.Clear();
        //        }

    }
}
