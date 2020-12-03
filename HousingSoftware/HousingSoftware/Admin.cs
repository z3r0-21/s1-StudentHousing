using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    class Admin
    {
        private string username;
        private string password;
        private List<Tenant> tenants = new List<Tenant>();

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

        public void SetTenants(List<Tenant> inputedTenants)
        {
            tenants = inputedTenants;
        }

        public List<Tenant> GetTenants()
        {
            return tenants;
        }

    }
}
