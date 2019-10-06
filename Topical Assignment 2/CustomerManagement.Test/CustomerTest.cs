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
            var sampleCustomer = new Customer
            {
                FirstName = "Zahra",
                LastName = "Bodaghi",
            };
            var expected = "Bodaghi,Zahra";
            //Act
            var result = sampleCustomer.FullName;
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
            Assert.AreEqual(expected: expected, actual: Customer.InstantanceCount);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            var sampleCustomer = new Customer(); 
            sampleCustomer.FirstName = "";
            Assert.AreEqual(expected: "", actual: sampleCustomer.FullName);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            var sampleCustomer = new Customer(); 
            sampleCustomer.LastName = "";
            Assert.AreEqual(expected: "", actual: sampleCustomer.LastName);
        }

    }

}
