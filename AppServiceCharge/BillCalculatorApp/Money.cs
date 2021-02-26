using System;
using System.Collections.Generic;
using System.Text;

namespace BillCalculatorApp
{
    public class Money
    {
        public int Dollar { get; set; }
        public int Cent { get; set; }

        public Money(int cents)
        {
            decimal actual = cents / 100;
            Dollar = (int)Math.Floor(actual);
            this.Cent = cents % 100;
        }
    }


}
