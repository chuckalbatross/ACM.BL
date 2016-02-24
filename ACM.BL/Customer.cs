using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;


namespace ACM.BL
{
    public class Customer
    {
        #region CustomerFields
        private string _lastName;
        #endregion

        public Customer()
            : this(0)
        {
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<CivicAddress>();     // Non-default constructors are used to ensure that an object
        }                                               // is in a valid state when it's constructed. We did not initialize 
                                                        // our string fields because they default to empty strings. We must
                                                        // initialize our list because it defaults to NULL.



        #region CustomerProperties                       
        public string FirstName { get; set; }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FullName
        {
            get
            {
                // protect against no first name
                if (LastName == null)
                {
                    return FirstName;
                }
                if (FirstName == null)
                {
                    return LastName;
                }
                return LastName + ", " + FirstName;
            }
        }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public List<CivicAddress> AddressList { get; set; }


        #endregion

        #region Methods
        public bool Validate()
        {
            //confirm that customer put in last name and email address
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress)) {
                isValid = false;
            }
            return isValid;
        }















        #endregion






    }
}
