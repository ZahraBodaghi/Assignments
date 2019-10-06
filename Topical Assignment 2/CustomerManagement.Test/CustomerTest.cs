using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * Zahra Bodaghi
 */
 //Zahra: I did change all the local variable to the lowercase. 10/05/2019 at 4:22pm
namespace CustomerManagement.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            var Customer = new Customer
                // ProfReynolds: local variables should be lowercase. Also, the
                // variable Customer would be confusing vs the class Customer
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
            Assert.AreEqual(expected: expected, actual: Customer.InstantanceCount);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            var customer = new Customer(); // ProfReynolds the variable should be lowercase
            customer.FirstName = "";
            Assert.AreEqual(expected: "", actual: customer.FullName);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            var customer = new Customer(); 
            customer.LastName = "";
            Assert.AreEqual(expected: "", actual: customer.LastName);
        }

    }

}
