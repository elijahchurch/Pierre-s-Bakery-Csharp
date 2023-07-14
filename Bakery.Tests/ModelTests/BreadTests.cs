using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests : IDisposable    
    {
        public void Dispose()
        {
            Bread.TotalBreadCost = 0;
            Bread.AmountOfLoaves = 0;
        }

        [TestMethod]
        public void BreadCostField_CanAccessBreadCostField_Int()
        {
        int testBreadCost = Bread.BreadCost;
        Assert.AreEqual(5, testBreadCost);
        }

        [TestMethod]
        public void TotalBreadCostField_CanAccessTotalBreadCost_Int()
        {
        int testTotalBreadCost = Bread.TotalBreadCost;
        Assert.AreEqual(0, testTotalBreadCost);
        }

        [TestMethod]
        public void AmountOfLoavesField_CanAccessAmountOfLoaves_Int()
        {
        int testAmountOfLoaves = Bread.AmountOfLoaves;
        Assert.AreEqual(0, testAmountOfLoaves);
        }

        [TestMethod]
        public void CalculateBreadOrder_UpdateAmountOfLoavesField_Int()
        {
            Bread.CalculateBreadOrder(2);
            int testAmountOfLoaves = Bread.AmountOfLoaves;
            Assert.AreEqual(2, testAmountOfLoaves);
        }

        [TestMethod]
        public void CalculateBreadOrder_UpdateTotalBreadCost_Int()
        {
            Bread.CalculateBreadOrder(2);
            int testTotalBreadCost = Bread.TotalBreadCost;
            Assert.AreEqual(10, testTotalBreadCost);
        }

        [TestMethod]
        public void CalculateBreadOrder_UpdateTotalBreadCostWithDeal_Int()
        {
            Bread.CalculateBreadOrder(3);
            int testTotalBreadCost = Bread.TotalBreadCost;
            Assert.AreEqual(10, testTotalBreadCost);
        }

        [TestMethod]
        public void CalculateBreadOrder_UpdateTotalsMultipleTimes_Int()
        {
        Bread.CalculateBreadOrder(5);
        Bread.CalculateBreadOrder(2);
        Bread.CalculateBreadOrder(1);
        int testTotalBreadCost = Bread.TotalBreadCost;
        int testAmountOfLoaves = Bread.AmountOfLoaves;
        Assert.AreEqual(35, testTotalBreadCost);
        Assert.AreEqual(8, testAmountOfLoaves);
        }


    }
}