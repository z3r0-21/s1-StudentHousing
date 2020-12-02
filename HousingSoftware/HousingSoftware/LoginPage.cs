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
        private string adminUsername = "admin";
        private string adminPassword = "admin";

        
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
                if (username == adminUsername && password == adminPassword)
                {
                    // redirecting to home page
                    AdminPage homePage = new AdminPage();
                    Hide();
                    homePage.ShowDialog();
                    Close();

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
