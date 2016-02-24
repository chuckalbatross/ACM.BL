using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        // int productID
        // string name
        // float currentPrice
        // int remainingInventory
        // retrieve()
        // validate()
        // save()

        #region Constructors
        public Product()
        {
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }
        #endregion



        #region Properties
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public float CurrentPrice { get; set; }
        public int RemainingInventory { get; set; }
        public string Description { get; set; }
        #endregion



        #region Methods

        /// <summary>
        /// Validates product input
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;
            // check isNullorWhitespace
            if (string.IsNullOrWhiteSpace(Name) || float.IsNaN(CurrentPrice) || (RemainingInventory <= 0))
            {
                isValid = false;
            }
            return isValid;
        }



        public Product Retrieve()
        {
            // Test code to retrieve product

            var product = new Product();
            return product;
        }

        public bool Save(Customer customer)
        {
            // code to save customer to persistent storage
            return true;
        }

        public override string ToString()
        {
            return ProductName;
        }
    

        #endregion










    }
}
