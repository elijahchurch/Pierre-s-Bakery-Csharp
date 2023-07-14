using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests :IDisposable
    {
        public void Dispose()
        {
            Pastry.TotalPastryCost = 0;
            Pastry.AmountOfPastries = 0;
        }

        [TestMethod]
        public void PastryCostField_CanAccessPastryCostField_Int()
        {
        int testPastryCost = Pastry.PastryCost;
        Assert.AreEqual(2, testPastryCost);        
        }

        [TestMethod]
        public void TotalPastryCostField_CanAccessTotalPastryCost_Int()
        {
        int testTotalPastryCost = Pastry.TotalPastryCost;
        Assert.AreEqual(0, testTotalPastryCost);
        }

        [TestMethod]
        public void AmountOfPastriesField_CanAccessAmountOfPastries_Int()
        {
        int testAmountOfPastries = Pastry.AmountOfPastries;
        Assert.AreEqual(0, testAmountOfPastries);
        }

        [TestMethod]
        public void CalculatePastryOrder_UpdateAmountOfPastriesField_Int()
        {
            Pastry.CalculatePastryOrder(4);
            int testAmountOfPastries = Pastry.AmountOfPastries;
            Assert.AreEqual(4, testAmountOfPastries);
        }

        [TestMethod]
        public void CalculatePastryOrder_UpdateTotalPastryCost_Int()
        {
            Pastry.CalculatePastryOrder(3);
            int testTotalPastryCost = Pastry.TotalPastryCost;
            Assert.AreEqual(6, testTotalPastryCost);
        }

        [TestMethod]
        public void CalculatePastryOrder_UpdatePastryCostWithDeal_Int()
        {
            Pastry.CalculatePastryOrder(4);
            int testTotalPastryCost = Pastry.TotalPastryCost;
            Assert.AreEqual(6, testTotalPastryCost);
        }


    }

    
}