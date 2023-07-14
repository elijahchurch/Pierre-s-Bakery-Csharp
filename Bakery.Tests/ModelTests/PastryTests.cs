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


    }

    
}