using BillCalculatorApp;
using System;
using System.Collections.Generic;

namespace BillCalculatorApp
{
    public class BillCalculatorApp
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("Bill Calculation Program:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");



            CalculateBill cb = new CalculateBill();
            bool isExecuted = cb.Execute();
            if (isExecuted) cb.Display();


        }
 

    }
}
