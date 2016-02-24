using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Device.Location;

namespace RandomTest
{
    [TestClass]
    public class CivicAddressTest
    {
        [TestMethod]
        public void CivicAddressOutputTest()
        {
            //-- Arrange
            CivicAddress actual = new CivicAddress();
            actual.AddressLine1 = "742 Redwing Park Dr.";
            actual.City = "Houston";
            actual.CountryRegion = "USA";
            actual.PostalCode = "77009";
            actual.StateProvince = "TX";


            //-- Act
            CivicAddress expected = new CivicAddress("742 Redwing Park Dr.", "", "", "Houston", "USA", "", "92867", "TX");

            //-- Assert
            Assert.AreEqual(expected.City, actual.City);

            // LESSON: can't compare reference types (objects) directly like you 
            // do with value types. MUST ASSERT EACH FIELD.          

        }
    }













}
