using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExistingValid()
        {
            //-- Assemble
            Customer expected = new Customer(1)
            {
                EmailAddress = "jbonner89@gmail.com",
                FirstName = "James",
                LastName = "Bonner"
            };
            CustomerRepository customerRepository = new CustomerRepository();

            //-- Act
            Customer actual = customerRepository.Retrieve(1);


            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);


        }
    }
}
