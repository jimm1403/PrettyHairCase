using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class CustomerRepository
    {
        static List<Customer> customerList = new List<Customer>();
        List<string> stringList = new List<string>();

        public void AddCustomerToList(Customer newCustomer)
        {
            customerList.Add(newCustomer);
        }
        public void ClearRepository()
        {
            customerList.Clear();
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

        public string Search(string searchWord)
        {
            
            string resultCustomer = "";
            List<string> searchLineList = GetListAsStringList();

            foreach (string customer in searchLineList)
            {
                if (customer.Contains(searchWord))
                {
                    resultCustomer = customer;
                }
            }
            if (!resultCustomer.Contains(searchWord))
            {
                resultCustomer = "Nothing found";
            }

            return resultCustomer;
        }
    }
}
