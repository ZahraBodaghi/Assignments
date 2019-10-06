using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderItemManagement;
/*
 * Zahra Bodaghi
 */
namespace OrderItemTest
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void OrderItemValidateValid()
        {
            var sampleOrderItem = new OrderItem();
            sampleOrderItem.OrderQuantity = 1;
            sampleOrderItem.ProductId = 100;
            sampleOrderItem.PurchasePrice = 10;
            Assert.AreEqual(expected: true, actual: sampleOrderItem.Validate());
        }
        [TestMethod]
        public void OrderItemValidateMissingQuantity()
        {
            var sampleOrderItem = new OrderItem();
            sampleOrderItem.PurchasePrice = 2;
            sampleOrderItem.ProductId = 100;
            Assert.AreEqual(expected: false, sampleOrderItem.Validate());
        }
        [TestMethod]
        public void OrderItemValidateMissingProductID()
        {
            var sampleOrderItem = new OrderItem();
            sampleOrderItem.OrderQuantity = 2;
            sampleOrderItem.ProductId = 100;
            Assert.AreEqual(expected: false, sampleOrderItem.Validate());
        }
        [TestMethod]
        public void OrderItemValidateMissingPurchasePrice()
        {
            var sampleOrderItem = new OrderItem();
            sampleOrderItem.OrderQuantity = 2;
            sampleOrderItem.ProductId = 100;
            Assert.AreEqual(expected: false, sampleOrderItem.Validate());
        }
    }
}
