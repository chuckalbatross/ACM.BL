using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "James";
            customer.LastName = "Bonner";

            string expected = "Bonner, James";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void FullNameFirstEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Bonner";
            string expected = "Bonner";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "James";
            string expected = "James";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Bonner";
            customer.EmailAddress = "jbonner89@gmail.com";
            bool expected = true;

            //-- Act
            bool actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateEmailEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Bonner";
            bool expected = false;

            //-- Act
            bool actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
