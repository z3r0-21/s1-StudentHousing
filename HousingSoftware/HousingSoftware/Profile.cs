using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    class Profile
    {
        private string username;
        private string password;

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
    }
}
