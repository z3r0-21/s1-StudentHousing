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
        Admin admin;
        Tenant currentTenant;
        public AdminPage()
        {
            InitializeComponent();
            admin = new Admin();
            
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentNum = Convert.ToInt32(tbxStudentNum.Text);
            string fname = tbxFirstName.Text;
            string password = tbxPassword.Text;

            if(!String.IsNullOrEmpty(tbxStudentNum.Text) && !String.IsNullOrEmpty(tbxFirstName.Text) && !String.IsNullOrEmpty(tbxPassword.Text))
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

    }
}
