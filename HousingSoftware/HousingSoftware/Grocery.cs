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
        private double price;
        
        // can add price ?

        public void SetName(string groceryName)
        {
            name = groceryName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }

        public double GetPrice()
        {
            return price;
        }
        public void InitialiseGrocery(string newName, double newPrice)
        {
            name = newName;
            price = newPrice;
        }
        public string GetInfo()
        {
            return $"{name} - ${price}";
        }

    }
}
