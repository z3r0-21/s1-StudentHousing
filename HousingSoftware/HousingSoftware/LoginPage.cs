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
    public partial class LoginPage : Form
    {
        private string correctUsername = "user";
        private string correctPassword = "password";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            if(!String.IsNullOrEmpty(tbxUsername.Text) && !String.IsNullOrEmpty(tbxPassword.Text))
            {
                if (username == correctUsername && password == correctPassword)
                {
                    // redirecting to home page
                    AdminPage homePage = new AdminPage();
                    homePage.ShowDialog();
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
            tbxUsername.Clear();
            tbxPassword.Clear();

        }
    }
}
