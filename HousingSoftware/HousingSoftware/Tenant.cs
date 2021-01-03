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

        public void SetStudentNumber(int studNum)
        {
            studentNumber = studNum;
        }

        public int GetStudentNumber()
        {
            return studentNumber;
        }

        public void SetFirstName(string fname)
        {
            firstname = fname;
        }

        public string GetFirstName()
        {
            return firstname;
        }

        public void SetPassword(string inputedPassword)
        {
            password = inputedPassword;
        }

        public string GetPassword()
        {
            return password;
        }

        public void InitializeTenant(int studNum, string fname, string inputedPassword)
        {
            studentNumber = studNum;
            firstname = fname;
            password = inputedPassword;
        }

        public void SetGroceriesTenant(List<Grocery> groceries)
        {
            groceriesTenant = groceries;
        }

        public List<Grocery> GetGroceriesTenant()
        {
            return groceriesTenant;
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
