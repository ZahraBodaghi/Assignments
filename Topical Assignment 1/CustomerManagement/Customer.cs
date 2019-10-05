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
        public Customer(int Customerid)
        {
            this.CustomerId = Customerid;
        }
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
        public string FullName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName))
                {
                    return $"{LastName},{FirstName}";
                }
                return LastName + FirstName;
            }
        }

        public int CustomerId { get; }

        public Customer Retrieve(int customerid)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        //Zahra: Capitalized the Save method. 10/5/2019 4:23 pm
        public bool Save(Customer customer) 
            // ProfReynolds: Method names should be capitalized
        {
            return true;
        }
    }
}
