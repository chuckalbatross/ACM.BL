using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateTestValid()
        {
            //-- Assemble
            Product product = new Product(1);
            product.CurrentPrice = 59.99f;
            product.Name = "Burton Snowboard";
            product.RemainingInventory = 50;
            bool expected = true;


            //-- Act
            bool actual = product.Validate();


            //-- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
