using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * Zahra Bodaghi
 */
namespace CustomerManagement.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            var Customer = new Customer
            {
                FirstName = "Zahra",
                LastName = "Bodaghi"
            };
            var expected = "Bodaghi, Zahra";
            //Act
            var result = Customer.FullName;
            //Assert
            Assert.AreEqual(expected: expected, actual: result);
        }
        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var expected = 3;
            //Act
            var c1 = new Customer { FirstName = "Ronnie" };
            Customer.InstantanceCount++;
            var c2 = new Customer { FirstName = "Lee" };
            Customer.InstantanceCount++;
            var c3 = new Customer { FirstName = "Yassi" };
            Customer.InstantanceCount++;
            //Assert
            Assert.AreEqual(expected: 3, actual: Customer.InstantanceCount);
        }
    }
}
