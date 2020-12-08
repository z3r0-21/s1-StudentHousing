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
    public partial class HousingApp : Form
    {
        private string adminUsername = "admin";
        private string adminPassword = "admin";

        Admin admin = new Admin();
        Tenant currentTenant;
        Tenant tenant1;

        Agreements newAgreement;

        int indexCurrTenant;


        Grocery currentGrocery;

        int indexSearchedTenant = -1;
        public HousingApp()
        {
            InitializeComponent();        
        }

        private void HousingApp_Load(object sender, EventArgs e)
        {
            MenuAdmin.Dock = DockStyle.Fill;
            MenuTenant.Dock = DockStyle.Fill;
            gbxLogin.Dock = DockStyle.Fill;

            MenuAdmin.Hide();
            btnLogOutAdmin.Hide();
            MenuTenant.Hide();
            btnLogOutTenant.Hide();

             
            //admin = new Admin();

            // make a tenant for testing
            tenant1 = new Tenant();
            tenant1.InitializeTenant(1, "user", "user");
            //tenant1.SetGroceriesTenant(admin.GetAllGroceries());
            admin.AddTenant(tenant1);
            

        }


        private int searchTenantProfile(int studentNum)
        {
            List<Tenant> allRegisteredTenants = admin.GetTenants();
            int index = -1;
            for (int i = 0; i < allRegisteredTenants.Count(); i++)
            {
                if (allRegisteredTenants[i].GetStudentNumber() == studentNum)
                {
                    index = i;
                }
            }
            return index;
        }

     
        private void RefreshComplaintsList()
        {

            lbxAllComplaints.Items.Clear();

            foreach (string complaint in admin.GetComplaints())
            {
                lbxAllComplaints.Items.Add(complaint);
            }
        }

        private void RefreshAgreements()
        {

            lbxAllAgreementsTenant.Items.Clear();
            lbxAllAgreementsAdmin.Items.Clear();

            foreach (Agreements agreement in admin.GetAgreements())
            {
                lbxAllAgreementsTenant.Items.Add($"{newAgreement.GetAgreementRatio()}% agreed: {agreement}");
                lbxAllAgreementsAdmin.Items.Add($"{newAgreement.GetAgreementRatio()}% agreed: {agreement}");
            }
        }
        private void AddGroceriesTenant(Tenant tenant, List<Grocery> groceries)
        {
            foreach (Grocery grocery in groceries)
            {
                tenant.AddGrocery(grocery);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentNum;
            string fname;
            string password;

            if(!String.IsNullOrEmpty(tbxStudentNumRegister.Text) && !String.IsNullOrEmpty(tbxFirstNameRegister.Text) && !String.IsNullOrEmpty(tbxPasswordRegister.Text))
            {
                studentNum = Convert.ToInt32(tbxStudentNumRegister.Text);
                fname = tbxFirstNameRegister.Text;
                password = tbxPasswordRegister.Text;

                if (searchTenantProfile(studentNum) == -1)
                {
                    currentTenant = new Tenant();
                    currentTenant.InitializeTenant(studentNum, fname, password);
                    //currentTenant.SetGroceriesTenant(admin.GetAllGroceries());

                    AddGroceriesTenant(currentTenant, admin.GetAllGroceries());
                    admin.AddTenant(currentTenant);
                    // add groceries to new registered tenants
                }
                else
                {
                    MessageBox.Show("Profile with same student number already exists!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the textboxes!");
            }
            tbxStudentNumRegister.Clear();
            tbxFirstNameRegister.Clear();
            tbxPasswordRegister.Clear();
        }

        private void btnRemoveTenant_Click(object sender, EventArgs e)
        {
            int studentNum;

            if (!String.IsNullOrEmpty(tbxStudentNumRemove.Text))
            {
                studentNum = Convert.ToInt32(tbxStudentNumRemove.Text);

                if (searchTenantProfile(studentNum) != -1)
                {
                    int index = searchTenantProfile(studentNum);
                    admin.RemoveTenantAt(index);
                }
                else
                {
                    MessageBox.Show("There is no such profile!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the textbox!");
            }
            tbxStudentNumRemove.Clear();
        }

        private int checkForTenantCredentials(string username, string password)
        {
            int index = -1;
            List<Tenant> tenants = admin.GetTenants();
            for (int i = 0;i < tenants.Count();i++)
            {
                if(tenants[i].GetStudentNumber().ToString() == username &&
                    tenants[i].GetPassword() == password)
                {
                    index = i;
                }
            }
            return index;
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            if (!String.IsNullOrEmpty(tbxUsernameLogin.Text) && !String.IsNullOrEmpty(tbxPasswordLogin.Text))
            {
                username = tbxUsernameLogin.Text;
                password = tbxPasswordLogin.Text;

                if (username == adminUsername && password == adminPassword)
                {
                    // redirecting to home page
                    gbxLogin.Hide();
                    MenuAdmin.Show();
                    btnLogOutAdmin.Show();
                    lbWelcomeMsgAdmin.Text = $"Welcome, {username}";
                }
                else if(checkForTenantCredentials(username, password) != -1)
                {
                    indexCurrTenant = checkForTenantCredentials(username, password);
                    gbxLogin.Hide();
                    MenuTenant.Show();
                    btnLogOutTenant.Show();

                    string fname = admin.GetTenants()[indexCurrTenant].GetFirstName();
                    lbWelcomeMsgTenant.Text = $"Welcome, {fname}";
                    showUnpaidGroceries(lbxUnpaidGroceries, indexCurrTenant);
                }
                else
                {
                    MessageBox.Show("There is no such profile! Check yours username and password!");
                }
            }
            else
            {
                MessageBox.Show("Please fill both your username and password to Log in!");
            }
            tbxUsernameLogin.Clear();
            tbxPasswordLogin.Clear();
        }

        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            MenuAdmin.Hide();
            btnLogOutAdmin.Hide();
            gbxLogin.Show();
        }

        private void btnLogOutTenant_Click(object sender, EventArgs e)
        {
            MenuTenant.Hide();
            btnLogOutTenant.Hide();
            gbxLogin.Show();
        }

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbxWriteComplaint.Text))
            {
                admin.AddComplaint(tbxWriteComplaint.Text);
                RefreshComplaintsList();
                tbxWriteComplaint.Clear();
                MessageBox.Show("Your complaint has been sent to Student Housing BV.");
            }
            else
            {
                MessageBox.Show("In order to send a complaint, please, enter a text in the text box.");
            }
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {

            if (admin.GetComplaints().Count > 0 && lbxAllComplaints.SelectedIndex != -1)
            {
                admin.RemoveComplaint(lbxAllComplaints.SelectedItem.ToString());
                RefreshComplaintsList();
            }
            else
            {
                MessageBox.Show("Please, make sure to select an item which you would like to be marked as done.");
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void showRecentGroceries()
        {
            // clear the listbox for all recent groceries
            lbxRecentGroceries.Items.Clear();

            foreach (Grocery grocery in admin.GetAllGroceries())
            {
                lbxRecentGroceries.Items.Add(grocery.GetInfo());
            }
        }

        private bool isGroceryExist(string groceryName)
        {
            foreach (Grocery grocery in admin.GetAllGroceries())
            {
                if (grocery.GetName() == groceryName)
                {
                    return true;
                }
            }
            return false;
        }

        private void addGroceryToTenants(Grocery grocery)
        {
            lbxUnpaidGroceries.Items.Clear();
            foreach (Tenant tenant in admin.GetTenants())
            {
                
                tenant.AddGrocery(grocery);
                
            }
        }

        private void btnAddGrocery_Click(object sender, EventArgs e)
        {
            string groceryName;
            double groceryPrice;

            if(!String.IsNullOrEmpty(tbxGroceryName.Text) && !String.IsNullOrEmpty(tbxGroceryPrice.Text))
            {
                groceryName = tbxGroceryName.Text;
                groceryPrice = Convert.ToDouble(tbxGroceryPrice.Text);

                currentGrocery = new Grocery();
                currentGrocery.InitialiseGrocery(groceryName, groceryPrice);

                if (!isGroceryExist(currentGrocery.GetName()))
                {
                    admin.AddGrocery(currentGrocery);
                    showRecentGroceries(); // Show recent groceries in the listbox Recent groceries

                    addGroceryToTenants(currentGrocery);
                }
                else
                {
                    MessageBox.Show("This grocery already exists in the list!");
                }
            }
            else
            {
                MessageBox.Show("Please write down a name and price of the grocery!");
            }
            tbxGroceryName.Clear();
            tbxGroceryPrice.Clear();
        }

        private void btnRemoveSelectedGrocery_Click(object sender, EventArgs e)
        {
            if(lbxRecentGroceries.SelectedIndex != -1)
            {
                int index = lbxRecentGroceries.SelectedIndex;
                admin.RemoveGroceryAt(index);
                showRecentGroceries();
            }
            else
            {
                MessageBox.Show("Please select a item to delete it!");
            }
        }

        private void btnRemoveAllGroceries_Click(object sender, EventArgs e)
        {
            admin.RemoveAllGroceries();
            showRecentGroceries();
        }

        private void btnShowToPayList_Click(object sender, EventArgs e)
        {

            lbxUnpaidGroceriesPerStudent.Items.Clear();
            int studNum;

            if (!String.IsNullOrEmpty(tbxStudNumUnpaidItems.Text))
            {
                studNum = Convert.ToInt32(tbxStudNumUnpaidItems.Text);

                indexSearchedTenant = searchTenantProfile(studNum);
                if (indexSearchedTenant != -1)
                {
                    showUnpaidGroceries(lbxUnpaidGroceriesPerStudent, indexSearchedTenant);
                }
                else
                {
                    MessageBox.Show("There is no student with such student number!");
                }

            }
            else
            {
                MessageBox.Show("Please fill the text box!");
            }
            tbxStudNumUnpaidItems.Clear();
        }

        private void btnMarkSelectedAsPaid_Click(object sender, EventArgs e)
        {
            int indexSelectedItem = lbxUnpaidGroceriesPerStudent.SelectedIndex;
            if (indexSearchedTenant != -1)
            {
                if (lbxUnpaidGroceriesPerStudent.Items.Count > 0)
                {
                    if(indexSelectedItem != -1)
                    {
                        admin.GetTenants()[indexSearchedTenant].GetGroceriesTenant().RemoveAt(indexSelectedItem);
                        lbxUnpaidGroceriesPerStudent.Items.RemoveAt(indexSelectedItem);
                        //showUnpaidGroceries(lbxUnpaidGroceriesPerStudent, indexSearchedTenant);
                    }
                    else
                    {
                        MessageBox.Show("Please select an item to mark it as paid!");
                    }
                }
                else
                {
                    MessageBox.Show("There are no unpaid groceries for this student!");
                }
            }
            else
            {
                MessageBox.Show("Student is not selected. Write student's student number!");
            }
        }

        public void markGroceriesAsPaid(int indexTenant)
        {
            admin.GetTenants()[indexTenant].RemoveAllGroceries();
        }

        private void btnMarkAllAsPaid_Click(object sender, EventArgs e)
        {
            if (indexSearchedTenant != -1)
            {
                if (lbxUnpaidGroceriesPerStudent.Items.Count > 0)
                {
                    markGroceriesAsPaid(indexSearchedTenant);
                    lbxUnpaidGroceriesPerStudent.Items.Clear();
                }
                else
                {
                    MessageBox.Show("There are no unpaid groceries!");
                }
            }
            else
            {
                MessageBox.Show("Student is not selected. Write student's student number!");
            }
        }


        private void btnClsSelectedLineRecentGroceries_Click(object sender, EventArgs e)
        {
            if (lbxRecentGroceries.SelectedIndex != -1)
            {
                lbxRecentGroceries.ClearSelected();
            }
            else
            {
                MessageBox.Show("There is no selected item!");
            }
        }

        private void btnClsSelectLinePayListGroceries_Click(object sender, EventArgs e)
        {
            if (lbxUnpaidGroceriesPerStudent.SelectedIndex != -1)
            {
                lbxUnpaidGroceriesPerStudent.ClearSelected();
            }
            else
            {
                MessageBox.Show("There is no selected item!");
            }
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            if(tbxAddAgreement.Text != "" && tbxAddAgreement.Text.Length > 20)
            {
                string agreement = tbxAddAgreement.Text;
                newAgreement = new Agreements();
                newAgreement.AddNewAgreement(agreement);
                admin.AddAgreement(newAgreement);

                RefreshAgreements();
            }
            else
            {
                MessageBox.Show("Please, make sure to enter a text containing 20 more charachters.");
            }
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            //selected agreement
            string selectedAgreement = lbxAllAgreementsTenant.SelectedItem.ToString();


        }

        private void btnDisagree_Click(object sender, EventArgs e)
        {
            //get the student number of the currently logged tennants
            Tenant currentTenantNr = admin.GetTenants()[indexCurrTenant];

            string agreement = lbxAllAgreementsTenant.SelectedItem.ToString();
            int stNumber = Convert.ToInt32(currentTenant.GetStudentNumber());

            //select
            
            newAgreement.Disagree(stNumber);


        }
    }
}
