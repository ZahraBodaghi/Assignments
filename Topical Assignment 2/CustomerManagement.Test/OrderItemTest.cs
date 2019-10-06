using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderItemManagement; // I had to add the namespace inspite of adding it ad the refrence the compiler still could not let me using it.
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
