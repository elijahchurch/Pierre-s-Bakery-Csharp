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
    }
}