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
    public partial class LoginForm : Form
    {
        // Create a superuser
        Admin superuser = new Admin("superuser", "superuser", "Admin", "Admin");

        //List of admins
        List<Admin> admins = new List<Admin>();

        Admin admin = new Admin("admin", "admin", "Admin", "Admin");


        Tenant tenant1;
        //int indexCurrTenant;

        public LoginForm()
        {
            InitializeComponent();
            admins.Add(admin);

            // create manual tenant only when the app is started
            tenant1 = new Tenant(1, "user", "user");
            admins[0].AddTenant(tenant1);

        }
        //public LoginForm(Admin admin)
        //{
        //    InitializeComponent();
        //    this.admin = admin;
        //}

        public LoginForm(List<Admin> admins)
        {
            InitializeComponent();
            this.admins = admins;
        }
        //public LoginForm(Admin admin, List<Admin> admins)
        //{
        //    InitializeComponent();
        //    this.admin = admin;
        //    this.admins = admins;

        //}


        private void LoginForm_Load(object sender, EventArgs e)
        {
            /*
            List<Admin> admins = new List<Admin>();
            Admin currentAdmin;
            // in the specified method
            currentAdmin = new Admin("user", "pass");
            admins.Add(currentAdmin);*/
        }

        private int checkForTenantCredentials(string username, string password)
        {
            int index = -1;

            foreach (Admin admin in admins)
            {
                List<Tenant> tenants = admin.Tenants;
                for (int i = 0; i < tenants.Count(); i++)
                {
                    if (tenants[i].StudentNumber.ToString() == username &&
                        tenants[i].Password == password)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        private int FindAdminIndex(string username, string password)
        {
            int index = -1;

            foreach (Admin admin in admins)
            {
                List<Tenant> tenants = admin.Tenants;
                for (int i = 0; i < tenants.Count(); i++)
                {
                    if (tenants[i].StudentNumber.ToString() == username &&
                        tenants[i].Password == password)
                    {
                        index = admins.IndexOf(admin);
                        break;
                    }
                }
            }
            return index;
        }


        private int checkForAdminCredentials(string username, string password)
        {
            int index = -1;

            for (int i = 0; i < admins.Count(); i++)
            {
                if (admins[i].Username.ToString() == username &&
                    admins[i].Password == password)
                {
                    index = i;
                }
            }

            return index;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            if (!String.IsNullOrEmpty(tbxUsernameLogin.Text) && !String.IsNullOrEmpty(tbxPasswordLogin.Text))
            {
                username = tbxUsernameLogin.Text;
                password = tbxPasswordLogin.Text;

                if (username == superuser.Username && password == superuser.Password)
                {
                    ManageAdmins manageAdminsForm = new ManageAdmins(admins);
                    manageAdminsForm.Show();
                    this.Hide();

                }
                else if (checkForAdminCredentials(username, password) != -1)
                {
                    int indexCurrAdmin = checkForAdminCredentials(username, password);
                    AdminForm adminForm = new AdminForm(indexCurrAdmin, admins);
                    adminForm.Show();
                    this.Hide();
                }
                else if (checkForTenantCredentials(username, password) != -1)
                {
                    int indexCurrTenant = checkForTenantCredentials(username, password);
                    TenantForm tenantForm = new TenantForm(indexCurrTenant, FindAdminIndex(username, password), admins);
                    tenantForm.Show();
                    this.Hide();
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
