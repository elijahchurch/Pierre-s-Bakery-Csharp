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
            Bread.TotalBreadOrder = 0;
            Bread.AmountofLoaves = 0;
        }

        [TestMethod]
        public void BreadCostField_CanAccessBreadCostField_Int()
        {
        int testBreadCost = Bread.BreadCost;
        Assert.AreEqual(5, testBreadCost);
        }

        [TestMethod]
        public void TotalBreadOrderField_CanAccessTotalBreadOrder_Int()
        {
        int testTotalBreadOrder = Bread.TotalBreadOrder;
        Assert.AreEqual(0, testTotalBreadOrder);
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

    }
}