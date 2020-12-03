using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Admin
    {
        private string username;
        private string password;
        private List<Tenant> tenants = new List<Tenant>();
        private List<Grocery> allGroceries = new List<Grocery>();
 

        public void SetUsername(string inputedUsername)
        {
            username = inputedUsername;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetPassword(string inputedPassword)
        {
            password = inputedPassword;
        }

        public string GetPassword()
        {
            return password;
        }


        public void AddTenant(Tenant inputedTenant)
        {
            tenants.Add(inputedTenant);
        }

        public void RemoveTenant(Tenant inputedTenant)
        {
            tenants.Remove(inputedTenant);
        }

        public void RemoveTenantAt(int index)
        {
            tenants.RemoveAt(index);
        }

        public void SetTenants(List<Tenant> inputedTenants)
        {
            tenants = inputedTenants;
        }

        public List<Tenant> GetTenants()
        {
            return tenants;
        }


        public void SetAllGroceries(List<Grocery> groceries)
        {
            allGroceries = groceries;
        }

        public List<Grocery> GetAllGroceries()
        {
            return allGroceries;
        }

        public void AddGrocery(Grocery grocery)
        {
            allGroceries.Add(grocery);
        }

        public void RemoveGrocery(Grocery grocery)
        {
            allGroceries.Remove(grocery);
        }

        public void RemoveGroceryAt(int index)
        {
            allGroceries.RemoveAt(index);
        }

        public void RemoveAllGroceries()
        {
            allGroceries.Clear();
        }

    }
}
