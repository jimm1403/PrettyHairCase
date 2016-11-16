using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class CustomerRepository
    {
        List<Customer> customerList = new List<Customer>();
        List<string> stringList = new List<string>();

        public void AddCustomerToList(Customer newCustomer)
        {
            customerList.Add(newCustomer);
        }

        public List<Customer> GetCustomerList()
        {
            return customerList;
        }

        public List<string> GetListAsStringList()
        {
            foreach (Customer customer in customerList)
            {
                stringList.Add(customer.ToString());
            }

            return stringList;
        }
    }
}
