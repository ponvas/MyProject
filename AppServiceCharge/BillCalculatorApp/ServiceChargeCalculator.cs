using System;
using System.Collections.Generic;
using System.Text;

namespace BillCalculatorApp
{
    public class ServiceChargeCalculator
    {
        public static double Food(double bill)

        {
            double tip, totalBill;
            tip = (bill * (float)0.1);
            totalBill = (tip + bill);
            return totalBill;

        }

        public static double Drink(double bill)
        {
            return bill;

        }
    }
}
