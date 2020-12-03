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
    public partial class AdminPage : Form
    {
        private string adminUsername = "admin";
        private string adminPassword = "admin";

        Admin admin;
        Tenant currentTenant;
        public AdminPage()
        {
            InitializeComponent();
            admin = new Admin();
            
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            MenuAdmin.Hide();
            MenuTenant.Hide();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentNum = Convert.ToInt32(tbxStudentNumRegister.Text);
            string fname = tbxFirstNameRegister.Text;
            string password = tbxPasswordRegister.Text;

            if(!String.IsNullOrEmpty(tbxStudentNumRegister.Text) && !String.IsNullOrEmpty(tbxFirstNameRegister.Text) && !String.IsNullOrEmpty(tbxPasswordRegister.Text))
            {
                currentTenant = new Tenant();
                currentTenant.InitializeTenant(studentNum, fname, password);
                admin.AddTenant(currentTenant);

            }
            else
            {
                MessageBox.Show("Please fill all the textboxes!");
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
