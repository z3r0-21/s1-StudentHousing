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

        Admin admin;
        Tenant currentTenant;
        Tenant tenant1;

        Agreements newAgreement;

        List<string> Complaints = new List<string>();
        Grocery currentGrocery;
        public HousingApp()
        {
            InitializeComponent();
            admin = new Admin();
            
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

            // Initialize admin 


            // make a tenant for testing
            tenant1 = new Tenant();
            tenant1.InitializeTenant(1, "user", "user");
            tenant1.SetGroceriesTenant(admin.GetAllGroceries());
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

        private void AddComplaints(string complaintText)
        {
            Complaints.Add(complaintText);
            RefreshComplaintsList();
        }

        private void MarkComplaintAsDone()
        {
            int selectedIndex = lbxAllComplaints.SelectedIndex;
            Complaints.RemoveAt(selectedIndex);


            RefreshComplaintsList();
        }

        private void RefreshComplaintsList()
        {

            lbxAllComplaints.Items.Clear();

            foreach (string complaint in Complaints)
            {
               lbxAllComplaints.Items.Add(complaint);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentNum = Convert.ToInt32(tbxStudentNumRegister.Text);
            string fname = tbxFirstNameRegister.Text;
            string password = tbxPasswordRegister.Text;

            if(!String.IsNullOrEmpty(tbxStudentNumRegister.Text) && !String.IsNullOrEmpty(tbxFirstNameRegister.Text) && !String.IsNullOrEmpty(tbxPasswordRegister.Text))
            {
                if (searchTenantProfile(studentNum) == -1)
                {
                    currentTenant = new Tenant();
                    currentTenant.InitializeTenant(studentNum, fname, password);
                    currentTenant.SetGroceriesTenant(admin.GetAllGroceries());
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
            int studentNum = Convert.ToInt32(tbxStudentNumRemove.Text);

            if (!String.IsNullOrEmpty(tbxStudentNumRemove.Text))
            {
                
                if(searchTenantProfile(studentNum) != -1)
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

        private void showUnpaidGroceries(int index)
        {
            lbxUnpaidGroceries.Items.Clear();
            List<Grocery> groceries = admin.GetTenants()[index].GetGroceriesTenant();
            foreach (Grocery grocery in groceries)
            {
                lbxUnpaidGroceries.Items.Add(grocery.GetName());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsernameLogin.Text;
            string password = tbxPasswordLogin.Text;
            if (!String.IsNullOrEmpty(tbxUsernameLogin.Text) && !String.IsNullOrEmpty(tbxPasswordLogin.Text))
            {
                if (username == adminUsername && password == adminPassword)
                {
                    // redirecting to home page
                    gbxLogin.Hide();
                    MenuAdmin.Show();
                    btnLogOutAdmin.Show();
                }
                else if(checkForTenantCredentials(username, password) != -1)
                {
                    int index = checkForTenantCredentials(username, password);
                    gbxLogin.Hide();
                    MenuTenant.Show();
                    btnLogOutTenant.Show();
                    showUnpaidGroceries(index);
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
            //send a complaint
            AddComplaints(tbxWriteComplaint.Text);
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            
            if(Complaints.Count > 0 && lbxAllComplaints.SelectedIndex != -1)
            {
                MarkComplaintAsDone();
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
                lbxRecentGroceries.Items.Add(grocery.GetName());
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
            string groceryName = tbxGroceryName.Text;
            if(!String.IsNullOrEmpty(tbxGroceryName.Text))
            {
                currentGrocery = new Grocery();
                currentGrocery.SetName(groceryName);
                if (!isGroceryExist(currentGrocery.GetName()))
                {
                    admin.AddGrocery(currentGrocery);
                    showRecentGroceries(); // Show recent groceries in the listbox Recent groceries

                    //addGroceryToTenants(currentGrocery);

                }
                else
                {
                    MessageBox.Show("This grocery already exists in the list!");
                }
            }
            else
            {
                MessageBox.Show("Please write down a name of the grocery!");
            }
            tbxGroceryName.Clear();
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

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            if(tbxAddAgreement.Text != "" && tbxAddAgreement.Text.Length > 20)
            {
                string agreement = tbxAddAgreement.Text;
                newAgreement = new Agreements();
                newAgreement.AddNewAgreement(agreement);

                lbxAllAgreementsTenant.Items.Add($"{newAgreement.GetAgreementRatio()}% agreed: {agreement}");
                lbxAllAgreementsAdmin.Items.Add(agreement);
            }
            else
            {
                MessageBox.Show("Please, make sure to enter a text containing 20 more charachters.");
                //test
            }
        }
    }
}
