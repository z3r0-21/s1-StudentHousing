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
        Admin admin = new Admin("admin", "admin");
        Tenant tenant1 = new Tenant();
        int indexCurrTenant;

        public LoginForm()
        {
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            tenant1.InitializeTenant(1, "user", "user");
            admin.AddTenant(tenant1);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            if (!String.IsNullOrEmpty(tbxUsernameLogin.Text) && !String.IsNullOrEmpty(tbxPasswordLogin.Text))
            {
                username = tbxUsernameLogin.Text;
                password = tbxPasswordLogin.Text;

                if (username == admin.GetUsername() && password == admin.GetPassword())
                {
                    AdminForm adminForm = new AdminForm(this,admin);
                    adminForm.Show();
                    this.Hide();
                    // redirecting to home page
                    //gbxLogin.Hide();
                    //MenuAdmin.Show();
                    ////btnLogOutAdmin.Show();
                    //lbWelcomeMsgAdmin.Text = $"Welcome, {username}";

                    // Make invisible groupbox for edit tenant credntials unitl a current tenant is searched for profile edit by the admin
                    //gbxEditTenant.Visible = false;
                }
                else if (checkForTenantCredentials(username, password) != -1)
                {
                    indexCurrTenant = checkForTenantCredentials(username, password);
                    
                    //gbxLogin.Hide();
                    //MenuTenant.Show();
                    //btnLogOutTenant.Show();

                    string fname = admin.GetTenants()[indexCurrTenant].GetFirstName();

                    TenantForm tenantForm = new TenantForm(this, admin);
                    tenantForm.Show();
                    this.Hide();
                    //lbWelcomeMsgTenant.Text = $"Welcome, {fname}";

                    /*  showUnpaidGroceries(lbxUnpaidGroceries, indexCurrTenant);
                      refreshHouseRules();*/
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
    }
}
