using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// RELATIONSHIP: COLLABORATION 
        /// CustomerRepository class uses Customer class to populate the entity
        public Customer Retrieve(int customerId) 
        {
            // Create an instance of the Customer class
            Customer customer = new Customer(customerId);

            // Code that retrieves teh defined customer

            // Temporary hard coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "jbonner89@gmail.com";
                customer.FirstName = "James";
                customer.LastName = "Bonner";
            }
            return customer;
        }

        /// <summary>
        /// Retrieve a list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer. 
        /// </summary>
        /// RELATIONSHIP: COLLABORATION 
        /// CustomerRepository class uses Customer class to serialize the entity
        public bool Save(Customer customer)
        {
            // Code that saves the defined user
            return true;
        }
    }
}
