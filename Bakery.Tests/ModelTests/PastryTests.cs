using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryCostField_CanAccessPastryCostField_Int()
        {
        int testPastryCost = Pastry.PastryCost;
        Assert.AreEqual(2, testPastryCost);
        }
    }
}