using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Tenant
    {
        private int studentNumber;
        private string firstname;
        private string password;
        private List<Grocery> groceriesTenant = new List<Grocery>();

        public Tenant(int studNum, string fname, string inputedPassword)
        {
            this.studentNumber = studNum;
            this.firstname = fname;
            this.password = inputedPassword;
        }

        // STUDENT NUMBER
        public int StudentNumber
        {
            set { this.studentNumber = value; }
            get { return this.studentNumber; }
        }

        // FIRST NAME
        public string FirstName
        {
            set { this.firstname = value; }
            get { return this.firstname; }
        }


        // PASSWORD
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }

        // Groceries
        public List<Grocery> GroceriesTenant
        {
            set { this.groceriesTenant = value; }
            get { return this.groceriesTenant; }
        }

        public void AddGrocery(Grocery grocery)
        {
            groceriesTenant.Add(grocery);
        }

        public void RemoveGrocery(Grocery grocery)
        {
            groceriesTenant.Remove(grocery);
        }

        public void RemoveGroceryAt(int index)
        {
            groceriesTenant.RemoveAt(index);
        }

        public void RemoveAllGroceries()
        {
            groceriesTenant.Clear();
        }
    }
}
