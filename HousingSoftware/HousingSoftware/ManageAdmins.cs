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
    public partial class ManageAdmins : Form
    {
        List<Admin> admins;
        Admin currentAdmin;
        int indexCurrAdminEdit;
        public ManageAdmins(List<Admin> admins)
        {
            InitializeComponent();
            this.admins = admins;
        }

        private void ManageAdmins_Load(object sender, EventArgs e)
        {
            gbxEditAdmin.Visible = false;
        }

        private int isAdminExist(string username)
        {
            int index = -1;
            foreach (Admin admin in admins)
            {
                if(admin.GetUsername() == username)
                {
                    index = admins.IndexOf(admin);
                }
            }
            return index;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fName;
            string lName;
            string username;
            string password;

            if(!String.IsNullOrEmpty(tbxFirstName.Text) && !String.IsNullOrEmpty(tbxLastName.Text) 
                && !String.IsNullOrEmpty(tbxUsername.Text) && !String.IsNullOrEmpty(tbxPassword.Text))
            {
                fName = tbxFirstName.Text;
                lName = tbxLastName.Text;
                username = tbxUsername.Text;
                password = tbxPassword.Text;

                if(isAdminExist(username) == -1)
                {
                    currentAdmin = new Admin(username, password, fName, lName);
                    admins.Add(currentAdmin);
                }
                else
                {
                    MessageBox.Show("This username is already used! Please choose new one!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the text boxes!");
            }
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxUsername.Clear();
            tbxPassword.Clear();
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            string username;
            if(!String.IsNullOrEmpty(tbxUsernameRemoveEditAdmin.Text))
            {
                username = tbxUsernameRemoveEditAdmin.Text;
                int index = isAdminExist(username);
                if (index != -1)
                {
                    admins.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("There is no an admin with such username!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the text box to remove admin profile!");
            }
            tbxUsernameRemoveEditAdmin.Clear();
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            string username;
            if (!String.IsNullOrEmpty(tbxUsernameRemoveEditAdmin.Text))
            {
                username = tbxUsernameRemoveEditAdmin.Text;
                int index = isAdminExist(username);
                if (index != -1)
                {
                    indexCurrAdminEdit = index;
                    gbxEditAdmin.Visible = true;
                    tbxFNameEditAdmin.Text = admins[index].FirstName;
                    tbxLNameEditAdmin.Text = admins[index].LastName;
                    tbxPasswordEditAdmin.Text = admins[index].GetPassword();
                }
                else
                {
                    MessageBox.Show("There is no an admin with such username!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the text box to edit admin profile!");
            }
            tbxUsernameRemoveEditAdmin.Clear();
        }

        private void btnSaveChangesAdminProfile_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbxFNameEditAdmin.Text) && !String.IsNullOrEmpty(tbxLNameEditAdmin.Text)
                && !String.IsNullOrEmpty(tbxPasswordEditAdmin.Text))
            {
                admins[indexCurrAdminEdit].FirstName = tbxFNameEditAdmin.Text;
                admins[indexCurrAdminEdit].LastName = tbxLNameEditAdmin.Text;
                admins[indexCurrAdminEdit].SetPassword(tbxPasswordEditAdmin.Text);
            }
            else
            {
                MessageBox.Show("Please fill all the text boxes to edit successfully this admin profile!");
            }
            tbxFNameEditAdmin.Clear();
            tbxLNameEditAdmin.Clear();
            tbxPasswordEditAdmin.Clear();

            gbxEditAdmin.Visible = false;
        }

        private void btnLogOutSuperuser_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(admins);
            loginForm.Show();
            this.Close();
        }
    }
}
