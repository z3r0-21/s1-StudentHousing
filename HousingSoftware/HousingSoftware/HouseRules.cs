using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class HouseRules
    {

        private string houseRule;

        public HouseRules(string newHouseRule)
        {
            this.houseRule = newHouseRule;
        }
 
        public string HouseRule
        {
            set { this.houseRule = value; }
            get { return this.houseRule; }
        }
    }
}
