using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    class Tenant
    {
        private int studentNumber;
        private string firstname;
        private string password;

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


    }
}
