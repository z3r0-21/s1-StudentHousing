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
    public partial class AdminForm : Form
    {
        HouseRules newHouseRule;
        int indexTenantEdit;
        Tenant currentTenant;
        Grocery currentGrocery;
        int indexSearchedTenant = -1;

        //LoginForm loginForm;
        Admin admin;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            //this.loginForm = loginForm;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Welcome msg for admin user
            lbWelcomeMsgAdmin.Text = $"Welcome, {admin.GetUsername()}";

            // Make edit tenants invisible when loading the admin menu
            gbxEditTenant.Visible = false;

            // Refresh the listbox containing all agreements
            RefreshAgreementsAdmin();

            // Refresh the listbox containing all complaints
            RefreshComplaints();
        }

        // Method for checking if there is student with such student number
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

        // Add groceries to new registered tenant
        private void AddGroceriesTenant(Tenant tenant, List<Grocery> groceries)
        {
            foreach (Grocery grocery in groceries)
            {
                tenant.AddGrocery(grocery);
            }
        }

        // Btn Register tenant
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentNum;
            string fname;
            string password;

            if (!String.IsNullOrEmpty(tbxStudentNumRegister.Text) && !String.IsNullOrEmpty(tbxFirstNameRegister.Text) && !String.IsNullOrEmpty(tbxPasswordRegister.Text))
            {
                studentNum = Convert.ToInt32(tbxStudentNumRegister.Text);
                fname = tbxFirstNameRegister.Text;
                password = tbxPasswordRegister.Text;

                if (searchTenantProfile(studentNum) == -1)
                {
                    currentTenant = new Tenant();
                    currentTenant.InitializeTenant(studentNum, fname, password);
                    //currentTenant.SetGroceriesTenant(admin.GetAllGroceries());

                    // Add groceries to new registered tenant
                    AddGroceriesTenant(currentTenant, admin.GetAllGroceries());
                    admin.AddTenant(currentTenant);
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

        // Btn Remove tenant
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

        // Btn Show chosen tenant profile for edit
        private void btnShowTenantProfileEdit_Click(object sender, EventArgs e)
        {
            int studNum;
            if (!String.IsNullOrEmpty(tbxStudNumSearchTenantEdit.Text))
            {
                studNum = Convert.ToInt32(tbxStudNumSearchTenantEdit.Text);
                indexTenantEdit = searchTenantProfile(studNum);
                if (indexTenantEdit != -1)
                {
                    // Show the groupbox for edit profile of the chosen tenant
                    gbxEditTenant.Visible = true;
                    string currentFName = admin.GetTenants()[indexTenantEdit].GetFirstName();
                    string currentPassword = admin.GetTenants()[indexTenantEdit].GetPassword();

                    // Show the current data for the searched tenant profile for edit
                    tbxEditFNameTenant.Text = currentFName;
                    tbxEditPasswordTenant.Text = currentPassword;
                }
                else
                {
                    MessageBox.Show("Tenant with such student number doesn't exist!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the text box to edit a tenant profile!");
            }
            tbxStudNumSearchTenantEdit.Clear();
        }

        // Btn Save changes after editing chosen tenant profile
        private void btnSaveChangesEditTenantProfile_Click(object sender, EventArgs e)
        {
            string fName;
            string password;

            if (!String.IsNullOrEmpty(tbxEditFNameTenant.Text) && !String.IsNullOrEmpty(tbxEditPasswordTenant.Text))
            {
                fName = tbxEditFNameTenant.Text;
                password = tbxEditPasswordTenant.Text;

                // Set new values for first name and password of the tenant
                admin.GetTenants()[indexTenantEdit].SetFirstName(fName);
                admin.GetTenants()[indexTenantEdit].SetPassword(password);

            }
            else
            {
                MessageBox.Show("Please fill all the text boxes!");
            }
            tbxEditFNameTenant.Clear();
            tbxEditPasswordTenant.Clear();
            gbxEditTenant.Visible = false;
        }

        // LOG OUT
        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(admin);
            loginForm.Show();
            this.Close();

        }

        // GROCERIES

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
            //lbxUnpaidGroceries.Items.Clear();
            foreach (Tenant tenant in admin.GetTenants())
            {

                tenant.AddGrocery(grocery);

            }
        }

        // Btn Add grocery
        private void btnAddGrocery_Click(object sender, EventArgs e)
        {
            string groceryName;
            double groceryPrice;

            if (!String.IsNullOrEmpty(tbxGroceryName.Text) && !String.IsNullOrEmpty(tbxGroceryPrice.Text))
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

        
        private void RemoveSelectedGroceryTenants(string groceryName)
        {
            foreach (Tenant tenant in admin.GetTenants())
            {
                foreach (Grocery grocery in tenant.GetGroceriesTenant())
                {
                    if (grocery.GetName() == groceryName)
                    {
                        tenant.RemoveGrocery(grocery);
                        break;
                    }
                }
            }
        }

        // Btn Remove selected grocery
        private void btnRemoveSelectedGrocery_Click(object sender, EventArgs e)
        {
            if (lbxRecentGroceries.SelectedIndex != -1)
            {
                int index = lbxRecentGroceries.SelectedIndex;
                //string[] currentGroceryItem = lbxRecentGroceries.SelectedItem.ToString().Split(' ');
                string selectedGroceryName = lbxRecentGroceries.SelectedItem.ToString().Split(' ')[0];

                admin.RemoveGroceryAt(index);
                showRecentGroceries();
                RemoveSelectedGroceryTenants(selectedGroceryName);
            }
            else
            {
                MessageBox.Show("Please select a item to delete it!");
            }
        }

        private void RemoveAllGroceriesTenants()
        {
            foreach (Tenant tenant in admin.GetTenants())
            {
                tenant.RemoveAllGroceries();
            }
        }

        // Btn remove all groceries
        private void btnRemoveAllGroceries_Click(object sender, EventArgs e)
        {
            admin.RemoveAllGroceries();
            RemoveAllGroceriesTenants();
            showRecentGroceries();
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


        // Btn show to-pay list groceries of a specified tenant
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

        // Btn mark selected grocery as paid for the specified tenant
        private void btnMarkSelectedAsPaid_Click(object sender, EventArgs e)
        {
            int indexSelectedItem = lbxUnpaidGroceriesPerStudent.SelectedIndex;
            if (indexSearchedTenant != -1)
            {
                if (lbxUnpaidGroceriesPerStudent.Items.Count > 0)
                {
                    if (indexSelectedItem != -1)
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

        // Btn Mark all groceries as paid for the specified tenant
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

        // Btn to clear the selected line in the Recent groceries listbox
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

        // Btn to clear the selected line in the to-pay list groceries listbox
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


        // COMPLAINTS
        private void RefreshComplaints() // Refreshes the listbox containing all complaints
        {

            lbxAllComplaints.Items.Clear();

            foreach (string complaint in admin.GetComplaints())
            {
                lbxAllComplaints.Items.Add(complaint);
            }
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e) // Removes the selected agreement from the listbox (and from the list itslef as well)
        {

            if (admin.GetComplaints().Count > 0 && lbxAllComplaints.SelectedIndex != -1)
            {
                admin.RemoveComplaint(lbxAllComplaints.SelectedItem.ToString());
                RefreshComplaints();
            }
            else
            {
                MessageBox.Show("Please, make sure to select an item which you would like to be marked as done.");
            }
        }

        private void SearchComplaints(string searchText) // Search all available complaints based on string input
        {
            lbxAllComplaints.Items.Clear();

            foreach (string complaint in admin.GetComplaints())
            {
                if (complaint.Contains(searchText))
                {
                    lbxAllComplaints.Items.Add(complaint);
                }
            }
        }

        private void btnSearchComplaint_Click(object sender, EventArgs e) // Search all complaints based on string input
        {
            SearchComplaints(tbxSearchComplaint.Text);
        }

        private void btnShowAllComplaints_Click(object sender, EventArgs e) // Show all complaints (can be used after searching)
        {
            RefreshComplaints();
        }

        //AGREEMENTS
        private void RefreshAgreementsAdmin() // Refreshes the listbox showing all agreements
        {
            lbxAllAgreementsAdmin.Items.Clear();

            foreach (Agreements agreement in admin.GetAgreements())
            {
                lbxAllAgreementsAdmin.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
            }
        }

        private void SearchAgreementsAdmin(string searchText) // Search all agreements based on string input
        {
            lbxAllAgreementsAdmin.Items.Clear();

            foreach (Agreements agreement in admin.GetAgreements())
            {
                if (agreement.GetAgreement().Contains(searchText))
                {
                    lbxAllAgreementsAdmin.Items.Add($"{agreement.GetAgreementRatio()}% agreed: {Convert.ToString(agreement.GetAgreement())}");
                }
            }
        }
        private void btnSearchAgreementAdmin_Click(object sender, EventArgs e) // Search all agreements based on string input
        {
            SearchAgreementsAdmin(tbxSearchAgreementsAdmin.Text);
        }

        private void btnShowAllAgreementsAdmin_Click(object sender, EventArgs e) // Show all agreements (can be used after searching)
        {
            RefreshAgreementsAdmin();
        }

    }
}
