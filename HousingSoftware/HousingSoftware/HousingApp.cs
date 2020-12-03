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
        public HousingApp()
        {
            InitializeComponent();
            admin = new Admin();
            
        }

        private void HousingApp_Load(object sender, EventArgs e)
        {
            MenuAdmin.Hide();
            btnLogOutAdmin.Hide();
            MenuTenant.Hide();
            btnLogOutTenant.Hide();
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

        private bool checkForTenantCredentials(string username, string password)
        {
            foreach (Tenant tenant in admin.GetTenants())
            {
                if(tenant.GetStudentNumber().ToString() == username &&
                    tenant.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
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
                else if(checkForTenantCredentials(username, password))
                {
                    gbxLogin.Hide();
                    MenuTenant.Show();
                    btnLogOutTenant.Show();
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


    }
}
