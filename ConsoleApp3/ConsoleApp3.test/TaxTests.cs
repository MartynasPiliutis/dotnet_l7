using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace ConsoleApp3.test
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void TaxShouldBe5PercentWhenIncomeIsLess40k()
        {
            //Arange
            //Act
            decimal result = Program.Tax(10000);
            //Assert
            Assert.AreEqual(result, 500);
        }

        [TestMethod]
        public void TaxShouldBe15PercentWhenIncomeIsMore40kAndLess100k()
        {
            //Arange
            //Act
            decimal result = Program.Tax(100000);
            //Assert
            Assert.AreEqual(result, 15000);
        }

        [TestMethod]
        public void TaxShouldBe25PercentWhenIncomeIsMore100k()
        {
            //Arange
            //Act
            decimal result = Program.Tax(1000000);
            //Assert
            Assert.AreEqual(result, 250000);
        }

        [TestMethod]
        public void TaxShouldBe0PercentWhenIncomeIs0()
        {
            //Arange
            //Act
            decimal result = Program.Tax(0);
            //Assert
            Assert.AreEqual(result, 0);
        }
    }
}
