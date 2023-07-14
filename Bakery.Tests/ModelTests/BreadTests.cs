using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadCostField_CanAccessBreadCostField_Int()
        {
        int testBreadCost = Bread.BreadCost;
        Assert.AreEqual(5, testBreadCost);
        }
    }
}