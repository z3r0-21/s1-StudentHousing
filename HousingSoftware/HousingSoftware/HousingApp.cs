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

            // make a tenant for testing
            tenant1 = new Tenant();
            tenant1.InitializeTenant(1, "user", "user");
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

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            if(tbxAddAgreement.Text != "" && tbxAddAgreement.Text.Length > 20)
            {
                string agreement = tbxAddAgreement.Text;
                newAgreement = new Agreements();
                newAgreement.AddNewAgreement(agreement);

                lbxAllAgreementsTenant.Items.Add(agreement);
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
