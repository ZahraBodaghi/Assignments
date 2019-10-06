using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * Zahra Bodaghi
 */

namespace Order.Test
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void OrderValidateValid()
        {
            var sampleOrder = new Order();
            var date = new System.DateTimeOffset();
            sampleOrder.OrderDate = date;
            Assert.AreEqual(expected: date, actual: sampleOrder.OrderDate);

        }
        [TestMethod]
        public void OrderValidateNoOrderDate()
        {
            var sampleOrder = new Order();
            sampleOrder.OrderDate = null;
            Assert.AreEqual(expected: null, actual: sampleOrder.OrderDate);
        }

    }
}
