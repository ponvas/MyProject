using NUnit.Framework;
using BillCalculatorApp;
using System.Collections.Generic;

namespace NUnitTestBillCalculatorApp
{
    public class NUnitTestBillCalculatorApp_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ServiceChargeFood_Test()
        {
            // Arrange
            var input = 1;
            var expectedOutput = 1.1000000014901161;
            // Act
            var actualOutput = ServiceChargeCalculator.Food(1);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [Test]
        public void ServiceChargeDrink_Test()
        {
            // Arrange
            var input = 1;
            var expectedOutput = 1;
            // Act
            var actualOutput = ServiceChargeCalculator.Drink(1);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [Test]
        public void Money_Test()
        {
            // Arrange
            var input = 150;
            var expectedCents = 50;
            var expecteddollars = 1;
            // Act
            Money mn = new Money(input);
            // Assert
            Assert.AreEqual(expectedCents, mn.Cent);
            Assert.AreEqual(expecteddollars, mn.Dollar);


        }
        [Test]
        public void DoCalc_Test()
        {
            // Arrange  
            FoodItem test = new FoodItem();
            test.price = 10;
            test.Type = "F";

            var expectedOutput = 11.000000014901161;

            List<FoodItem> lst = new List<FoodItem>();
            lst.Add(test);

             // Act
           CalculateBill cb = new CalculateBill();
            cb.Foodlist = lst;
            var output = cb.DoCalc();

              // Assert
            Assert.AreEqual(expectedOutput, output);
    

       

        }

        [Test]
        public void DoDisplay_Test()
        {
            // Arrange  
             CalculateBill cb = new CalculateBill();
            cb.totalAmount = 335;


            // Act

            cb.Display();

            // Assert





        }
    }
}