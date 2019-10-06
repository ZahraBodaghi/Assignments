/*
 * Zahra Bodaghi
 */
using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class Customer
    {
        public Customer()
        {

        }
        #region Properties, Variables and Fields
        public Customer(int customerid)
        {
            this.CustomerId = customerid;
        }
        /// <summary>
        /// static variable which may be tracked as an instance count
        /// </summary>
        public static int InstantanceCount { get; set; }
        private string _lastName;
        public string LastName 
        { 
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        #endregion
        /// <summary>
        /// concatenates the last & first names
        /// </summary>
        public string FullName
        {
            get
            {
                if (!CustomerExtensions.IsNullOrWhiteSpace(FirstName) && !CustomerExtensions.IsNullOrWhiteSpace(LastName))
                {
                    return $"{LastName},{FirstName}";
                }
                return LastName + FirstName;
            }
        }

        /// <summary>
        /// retrives a customer record based on the customer id
        /// </summary>
        /// <param name="customerid"> id of the record to be retrived </param>
        /// <returns></returns>
        
        public Customer Retrieve(int customerid)=> new Customer();
        /// <summary>
        /// retrive a list of all customers
        /// </summary>
        /// <returns>the customer record </returns>
        public List<Customer> Retrieve() => new List<Customer>();
        /// <summary>
        /// saves a single record to the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>list of customers</returns>
        public bool Save(Customer customer) => true;
        /// <summary>
        /// examines the customer properties and confirms consist and valid data
        /// </summary>
        /// <returns>true if valid</returns>
        public bool Validate()
        {
            return !CustomerExtensions.IsNullOrWhiteSpace(LastName) && !CustomerExtensions.IsNullOrWhiteSpace(FirstName);

        }
    }
    static class CustomerExtensions
    {
        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }
        public static bool IsNullOrWhiteSpace(this string content)
        {
            return string.IsNullOrWhiteSpace(content);
        }
    }
}
