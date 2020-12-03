using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Grocery
    {
        private string name;
        
        // can add price ?

        public void SetName(string groceryName)
        {
            name = groceryName;
        }

        public string GetName()
        {
            return name;
        }

    }
}
