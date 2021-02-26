using BillCalculatorApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillCalculatorApp { 
    public class CalculateBill
    {
           public double totalAmount = 0;
        private double amount;
        public List<FoodItem> Foodlist;


        public bool  Execute()
        {
            // add constructor code here
            Foodlist = new List<FoodItem>();
            bool isCollected =CollectItems(true);
            if (isCollected)
            {

                totalAmount=DoCalc();
                return true;
            }
            Console.WriteLine("No Items to Calculate....");
            return false;
        }

        public bool CollectItems(bool valid)
        {
            // add this method's code here
            while (valid)
            {
                Console.Write("Plese enter 'Y' to feed the price, press 'D' once done .");
                string response = Console.ReadLine();
                if (response == "D") break;

                FoodItem fdItem = new FoodItem();
                Console.Write("Please enter your Food Type  Type 'D' for Drink and 'F' for Food ");

                fdItem.Type = Console.ReadLine();

                Console.WriteLine("Plese enter price for the item .");

                valid = double.TryParse(Console.ReadLine(), out amount);

                if (valid)
                {
                    fdItem.price = amount;
                    Foodlist.Add(fdItem);
                }
            }

            if (Foodlist.Count > 0) return true;
            else
                return false;

         


        }
        public double DoCalc()
        {
            double total = 0;

            foreach (var p in Foodlist)
            {
                if (p.Type == "F")
                    total += ServiceChargeCalculator.Food(p.price);
                else
                    total += ServiceChargeCalculator.Drink(p.price);
            }
            return total;
         }


        public  void Display()
        {
            if (totalAmount > 0)
            {
                Money money = new Money((int)totalAmount);
                Console.WriteLine("$" + money.Dollar + "." + money.Cent);
            }

        }

    }
}
