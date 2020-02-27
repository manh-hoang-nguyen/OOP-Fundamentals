using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.BL
{
  public  class CustomerRepository
    { 
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public Customer Retrieve(int customerId)
        {

            Customer customer = new Customer(customerId);

            //temporary code
            if (customerId == 1)
            {
                customer.EmailAddress = "Test@gmail.com";
                customer.FirstName = "Nguyen";
                customer.LastName = "Manh Hoang";
            }
            return customer;
        }
        public bool Save()
        {
            return true;
        }
    }
}
