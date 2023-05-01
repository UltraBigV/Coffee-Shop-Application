using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_CShrpSA
{
    class Order : Interface1
    {
        public void TotalOrdrerSummary()
        {
            throw new NotImplementedException();
        }
        String coffeeType = "";
        float price = 0;
        String sizeOfCoffee = "";
        int quantity = 0;
        String addedIngredients = "";
        Order(String coffeeType, float price, String sizeOfCoffee, int quantity, String addedIngredients)
        {
            this.coffeeType = coffeeType;
            this.price = price;
            this.sizeOfCoffee = sizeOfCoffee;
            this.quantity = quantity;
            this.addedIngredients = addedIngredients;
        }
        public virtual double TotalOrderSummary(double price, int quantity)
        {
            return price * quantity;
        }
        public virtual String TotalOrderSummary()
        {
            String text = quantity + " | " + coffeeType + ", " + sizeOfCoffee + ", " + addedIngredients + " | " + price + " | " + TotalOrderSummary(price, quantity);
            return text;
        }
    }
}
