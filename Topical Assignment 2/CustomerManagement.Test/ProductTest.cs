using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductManagement;
/*
 * Zahra Bodaghi
 */
namespace ProductTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            var sampleProduct = new Product();
            var name = "ICE CREAME";
            sampleProduct.ProductName = name;
            Assert.AreEqual(expected: name, actual: sampleProduct.ProductName);

        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            var sampleProduct = new Product();
            sampleProduct.ProductName = "";
            Assert.AreEqual(expected:"", actual: sampleProduct.ProductName);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            var sampleProduct = new Product();
            sampleProduct.ProductName = "";
            Assert.AreEqual(expected: "", actual: sampleProduct.ProductName);
        }

    }
}