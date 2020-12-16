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

        LoginForm LoginForm;
        Admin admin;
        int indexSearchedTenant = -1;
        public TenantForm(LoginForm loginForm, Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.LoginForm = loginForm;
        }

        private void HousingApp_Load(object sender, EventArgs e)
        {
            //lbTime.Text = DateTime.Now.ToString("HH:mm");
            //lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd");


            //MenuAdmin.Dock = DockStyle.Fill;
            //MenuTenant.Dock = DockStyle.Fill;
            //gbxLogin.Dock = DockStyle.Fill;

            //MenuAdmin.Hide();
            //btnLogOutAdmin.Hide();
            MenuTenant.Hide();
            btnLogOutTenant.Hide();


            //admin = new Admin();

            // make a tenant for testing
            tenant1 = new Tenant();
            tenant1.InitializeTenant(1, "user", "user");
            //tenant1.SetGroceriesTenant(admin.GetAllGroceries());
            admin.AddTenant(tenant1);


        }


        //private int searchTenantProfile(int studentNum)
        //{
        //    List<Tenant> allRegisteredTenants = admin.GetTenants();
        //    int index = -1;
        //    for (int i = 0; i < allRegisteredTenants.Count(); i++)
        //    {
        //        if (allRegisteredTenants[i].GetStudentNumber() == studentNum)
        //        {
        //            index = i;
        //        }
        //    }
        //    return index;
        //}


        //private void RefreshComplaintsList()
        //{

        //    lbxAllComplaints.Items.Clear();

        //    foreach (string complaint in admin.GetComplaints())
        //    {
        //        lbxAllComplaints.Items.Add(complaint);
        //    }
        //}

        //private void SearchComplaints(string searchText)
        //{
        //    lbxAllComplaints.Items.Clear();

        //    foreach (string complaint in admin.GetComplaints())
        //    {
        //        if (complaint.Contains(searchText))
        //        {
        //            lbxAllComplaints.Items.Add(complaint);
        //        }
        //    }
        //}


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

        //private void AddGroceriesTenant(Tenant tenant, List<Grocery> groceries)
        //{
        //    foreach (Grocery grocery in groceries)
        //    {
        //        tenant.AddGrocery(grocery);
        //    }
        //}
        //private void btnRegister_Click(object sender, EventArgs e)
        //{
        //    int studentNum;
        //    string fname;
        //    string password;

        //    if (!String.IsNullOrEmpty(tbxStudentNumRegister.Text) && !String.IsNullOrEmpty(tbxFirstNameRegister.Text) && !String.IsNullOrEmpty(tbxPasswordRegister.Text))
        //    {
        //        studentNum = Convert.ToInt32(tbxStudentNumRegister.Text);
        //        fname = tbxFirstNameRegister.Text;
        //        password = tbxPasswordRegister.Text;

        //        if (searchTenantProfile(studentNum) == -1)
        //        {
        //            currentTenant = new Tenant();
        //            currentTenant.InitializeTenant(studentNum, fname, password);
        //            //currentTenant.SetGroceriesTenant(admin.GetAllGroceries());

        //            AddGroceriesTenant(currentTenant, admin.GetAllGroceries());
        //            admin.AddTenant(currentTenant);
        //            // add groceries to new registered tenants
        //        }
        //        else
        //        {
        //            MessageBox.Show("Profile with same student number already exists!");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please fill all the textboxes!");
        //    }
        //    tbxStudentNumRegister.Clear();
        //    tbxFirstNameRegister.Clear();
        //    tbxPasswordRegister.Clear();
        //}

        //private void btnRemoveTenant_Click(object sender, EventArgs e)
        //{
        //    int studentNum;

        //    if (!String.IsNullOrEmpty(tbxStudentNumRemove.Text))
        //    {
        //        studentNum = Convert.ToInt32(tbxStudentNumRemove.Text);

        //        if (searchTenantProfile(studentNum) != -1)
        //        {
        //            int index = searchTenantProfile(studentNum);
        //            admin.RemoveTenantAt(index);
        //        }
        //        else
        //        {
        //            MessageBox.Show("There is no such profile!");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please fill the textbox!");
        //    }
        //    tbxStudentNumRemove.Clear();
        //}

        //private int checkForTenantCredentials(string username, string password)
        //{
        //    int index = -1;
        //    List<Tenant> tenants = admin.GetTenants();
        //    for (int i = 0; i < tenants.Count(); i++)
        //    {
        //        if (tenants[i].GetStudentNumber().ToString() == username &&
        //            tenants[i].GetPassword() == password)
        //        {
        //            index = i;
        //        }
        //    }
        //    return index;
        //}

        //private void showUnpaidGroceries(ListBox unpaidGroceries, int index)
        //{
        //    //lbxUnpaidGroceries.Items.Clear();
        //    unpaidGroceries.Items.Clear();
        //    List<Grocery> groceries = admin.GetTenants()[index].GetGroceriesTenant();
        //    foreach (Grocery grocery in groceries)
        //    {
        //        //lbxUnpaidGroceries.Items.Add(grocery.GetInfo());
        //        unpaidGroceries.Items.Add(grocery.GetInfo());
        //    }
        //}


        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string username;
        //    string password;

        //    if (!String.IsNullOrEmpty(tbxUsernameLogin.Text) && !String.IsNullOrEmpty(tbxPasswordLogin.Text))
        //    {
        //        username = tbxUsernameLogin.Text;
        //        password = tbxPasswordLogin.Text;

        //        if (username == adminUsername && password == adminPassword)
        //        {
        //            // redirecting to home page
        //            gbxLogin.Hide();
        //            MenuAdmin.Show();
        //            btnLogOutAdmin.Show();
        //            lbWelcomeMsgAdmin.Text = $"Welcome, {username}";

        //            // Make invisible groupbox for edit tenant credntials unitl a current tenant is searched for profile edit by the admin
        //            gbxEditTenant.Visible = false;
        //        }
        //        else if (checkForTenantCredentials(username, password) != -1)
        //        {
        //            indexCurrTenant = checkForTenantCredentials(username, password);
        //            gbxLogin.Hide();
        //            MenuTenant.Show();
        //            btnLogOutTenant.Show();

        //            string fname = admin.GetTenants()[indexCurrTenant].GetFirstName();
        //            lbWelcomeMsgTenant.Text = $"Welcome, {fname}";
        //            showUnpaidGroceries(lbxUnpaidGroceries, indexCurrTenant);
        //            refreshHouseRules();
        //        }
        //        else
        //        {
        //            MessageBox.Show("There is no such profile! Check yours username and password!");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please fill both your username and password to Log in!");
        //    }
        //    tbxUsernameLogin.Clear();
        //    tbxPasswordLogin.Clear();
        //}

        //private void btnLogOutAdmin_Click(object sender, EventArgs e)
        //{
        //    MenuAdmin.Hide();
        //    btnLogOutAdmin.Hide();
        //    gbxLogin.Show();
        //}

        private void btnLogOutTenant_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
            //MenuTenant.Hide();
            //btnLogOutTenant.Hide();
            //gbxLogin.Show();
        }

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

//        private void showRecentGroceries()
//        {
//            // clear the listbox for all recent groceries
//            lbxRecentGroceries.Items.Clear();

//            foreach (Grocery grocery in admin.GetAllGroceries())
//            {
//                lbxRecentGroceries.Items.Add(grocery.GetInfo());
//            }
//        }

//        private bool isGroceryExist(string groceryName)
//        {
//            foreach (Grocery grocery in admin.GetAllGroceries())
//            {
//                if (grocery.GetName() == groceryName)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private void addGroceryToTenants(Grocery grocery)
//        {
//            lbxUnpaidGroceries.Items.Clear();
//            foreach (Tenant tenant in admin.GetTenants())
//            {

//                tenant.AddGrocery(grocery);

//            }
//        }

//        private void btnAddGrocery_Click(object sender, EventArgs e)
//        {
//            string groceryName;
//            double groceryPrice;

//            if (!String.IsNullOrEmpty(tbxGroceryName.Text) && !String.IsNullOrEmpty(tbxGroceryPrice.Text))
//            {
//                groceryName = tbxGroceryName.Text;
//                groceryPrice = Convert.ToDouble(tbxGroceryPrice.Text);

//                currentGrocery = new Grocery();
//                currentGrocery.InitialiseGrocery(groceryName, groceryPrice);

//                if (!isGroceryExist(currentGrocery.GetName()))
//                {
//                    admin.AddGrocery(currentGrocery);
//                    showRecentGroceries(); // Show recent groceries in the listbox Recent groceries

//                    addGroceryToTenants(currentGrocery);
//                }
//                else
//                {
//                    MessageBox.Show("This grocery already exists in the list!");
//                }
//            }
//            else
//            {
//                MessageBox.Show("Please write down a name and price of the grocery!");
//            }
//            tbxGroceryName.Clear();
//            tbxGroceryPrice.Clear();
//        }

//        private void RemoveSelectedGroceryTenants(string groceryName)
//        {
//            foreach (Tenant tenant in admin.GetTenants())
//            {
//                foreach (Grocery grocery in tenant.GetGroceriesTenant())
//                {
//                    if (grocery.GetName() == groceryName)
//                    {
//                        tenant.RemoveGrocery(grocery);
//                        break;
//                    }
//                }
//            }
//        }

//        private void btnRemoveSelectedGrocery_Click(object sender, EventArgs e)
//        {
//            if (lbxRecentGroceries.SelectedIndex != -1)
//            {
//                int index = lbxRecentGroceries.SelectedIndex;
//                //string[] currentGroceryItem = lbxRecentGroceries.SelectedItem.ToString().Split(' ');
//                string selectedGroceryName = lbxRecentGroceries.SelectedItem.ToString().Split(' ')[0];

//                admin.RemoveGroceryAt(index);
//                showRecentGroceries();
//                RemoveSelectedGroceryTenants(selectedGroceryName);
//            }
//            else
//            {
//                MessageBox.Show("Please select a item to delete it!");
//            }
//        }

//        private void RemoveAllGroceriesTenants()
//        {
//            foreach (Tenant tenant in admin.GetTenants())
//            {
//                tenant.RemoveAllGroceries();
//            }
//        }

//        private void btnRemoveAllGroceries_Click(object sender, EventArgs e)
//        {
//            admin.RemoveAllGroceries();
//            RemoveAllGroceriesTenants();
//            showRecentGroceries();
//        }

//        private void btnShowToPayList_Click(object sender, EventArgs e)
//        {

//            lbxUnpaidGroceriesPerStudent.Items.Clear();
//            int studNum;

//            if (!String.IsNullOrEmpty(tbxStudNumUnpaidItems.Text))
//            {
//                studNum = Convert.ToInt32(tbxStudNumUnpaidItems.Text);

//                indexSearchedTenant = searchTenantProfile(studNum);
//                if (indexSearchedTenant != -1)
//                {
//                    showUnpaidGroceries(lbxUnpaidGroceriesPerStudent, indexSearchedTenant);
//                }
//                else
//                {
//                    MessageBox.Show("There is no student with such student number!");
//                }

//            }
//            else
//            {
//                MessageBox.Show("Please fill the text box!");
//            }
//            tbxStudNumUnpaidItems.Clear();
//        }

//        private void btnMarkSelectedAsPaid_Click(object sender, EventArgs e)
//        {
//            int indexSelectedItem = lbxUnpaidGroceriesPerStudent.SelectedIndex;
//            if (indexSearchedTenant != -1)
//            {
//                if (lbxUnpaidGroceriesPerStudent.Items.Count > 0)
//                {
//                    if (indexSelectedItem != -1)
//                    {
//                        admin.GetTenants()[indexSearchedTenant].GetGroceriesTenant().RemoveAt(indexSelectedItem);
//                        lbxUnpaidGroceriesPerStudent.Items.RemoveAt(indexSelectedItem);
//                        //showUnpaidGroceries(lbxUnpaidGroceriesPerStudent, indexSearchedTenant);
//                    }
//                    else
//                    {
//                        MessageBox.Show("Please select an item to mark it as paid!");
//                    }
//                }
//                else
//                {
//                    MessageBox.Show("There are no unpaid groceries for this student!");
//                }
//            }
//            else
//            {
//                MessageBox.Show("Student is not selected. Write student's student number!");
//            }
//        }

//        public void markGroceriesAsPaid(int indexTenant)
//        {
//            admin.GetTenants()[indexTenant].RemoveAllGroceries();
//        }

//        private void btnMarkAllAsPaid_Click(object sender, EventArgs e)
//        {
//            if (indexSearchedTenant != -1)
//            {
//                if (lbxUnpaidGroceriesPerStudent.Items.Count > 0)
//                {
//                    markGroceriesAsPaid(indexSearchedTenant);
//                    lbxUnpaidGroceriesPerStudent.Items.Clear();
//                }
//                else
//                {
//                    MessageBox.Show("There are no unpaid groceries!");
//                }
//            }
//            else
//            {
//                MessageBox.Show("Student is not selected. Write student's student number!");
//            }
//        }


//        private void btnClsSelectedLineRecentGroceries_Click(object sender, EventArgs e)
//        {
//            if (lbxRecentGroceries.SelectedIndex != -1)
//            {
//                lbxRecentGroceries.ClearSelected();
//            }
//            else
//            {
//                MessageBox.Show("There is no selected item!");
//            }
//        }

//        private void btnClsSelectLinePayListGroceries_Click(object sender, EventArgs e)
//        {
//            if (lbxUnpaidGroceriesPerStudent.SelectedIndex != -1)
//            {
//                lbxUnpaidGroceriesPerStudent.ClearSelected();
//            }
//            else
//            {
//                MessageBox.Show("There is no selected item!");
//            }
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

//        private void btnShowTenantProfileEdit_Click(object sender, EventArgs e)
//        {
//            int studNum;
//            if (!String.IsNullOrEmpty(tbxStudNumSearchTenantEdit.Text))
//            {
//                studNum = Convert.ToInt32(tbxStudNumSearchTenantEdit.Text);
//                indexTenantEdit = searchTenantProfile(studNum);
//                if (indexTenantEdit != -1)
//                {
//                    gbxEditTenant.Visible = true;
//                    string currentFName = admin.GetTenants()[indexTenantEdit].GetFirstName();
//                    string currentPassword = admin.GetTenants()[indexTenantEdit].GetPassword();

//                    // Show the current data for the searched tenant profile for edit
//                    tbxEditFNameTenant.Text = currentFName;
//                    tbxEditPasswordTenant.Text = currentPassword;
//                }
//                else
//                {
//                    MessageBox.Show("Tenant with such student number doesn't exist!");
//                }
//            }
//            else
//            {
//                MessageBox.Show("Please fill the text box to edit a tenant profile!");
//            }
//            tbxStudNumSearchTenantEdit.Clear();
//        }

//        private void btnSaveChangesEditTenantProfile_Click(object sender, EventArgs e)
//        {
//            string fName;
//            string password;

//            if (!String.IsNullOrEmpty(tbxEditFNameTenant.Text) && !String.IsNullOrEmpty(tbxEditPasswordTenant.Text))
//            {
//                fName = tbxEditFNameTenant.Text;
//                password = tbxEditPasswordTenant.Text;

//                // Set new values for first name and password of the tenant
//                admin.GetTenants()[indexTenantEdit].SetFirstName(fName);
//                admin.GetTenants()[indexTenantEdit].SetPassword(password);

//            }
//            else
//            {
//                MessageBox.Show("Please fill all the text boxes!");
//            }
//            tbxEditFNameTenant.Clear();
//            tbxEditPasswordTenant.Clear();
//            gbxEditTenant.Visible = false;
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
