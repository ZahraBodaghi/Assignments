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
                LastName = "Bodaghi",
            };
            var expected = "Bodaghi,Zahra";
            //Act
            var result = Customer.FullName;
            //Assert
            Assert.AreEqual(expected: expected, actual: result);
        }
        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            int expected = 3;
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
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            var Customer = new Customer();
            Customer.FirstName = "";
            Assert.AreEqual(expected: "", actual: Customer.FullName);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            var Customer = new Customer();
            Customer.LastName = "";
            Assert.AreEqual(expected: "", actual: Customer.LastName);
        }

    }

}
