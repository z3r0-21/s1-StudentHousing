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

        private void SearchComplaints(string searchText)
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

                    //AddGroceriesTenant(currentTenant, admin.GetAllGroceries());
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
            for (int i = 0; i < tenants.Count(); i++)
            {
                if (tenants[i].GetStudentNumber().ToString() == username &&
                    tenants[i].GetPassword() == password)
                {
                    index = i;
                }
            }
            return index;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            gbxEditTenant.Visible = false;
        }

        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(admin);
            loginForm.Show();
            this.Close();

        }
    }
}
