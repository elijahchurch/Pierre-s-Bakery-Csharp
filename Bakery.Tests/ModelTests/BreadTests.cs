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
            Bread.AmountofLoaves = 0;
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
        public void AmountofLoavesField_CanAccessAmountofLoaves_Int()
        {
        int testAmountofLoaves = Bread.AmountofLoaves;
        Assert.AreEqual(0, testAmountofLoaves);
        }

        [TestMethod]
        public void CalculateBreadOrder_UpdateAmountOfLoavesField_Int()
        {
            Bread.CalculateBreadOrder(2);
            int testAmountofLoaves = Bread.AmountofLoaves;
            Assert.AreEqual(2, testAmountofLoaves);
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



    }
}