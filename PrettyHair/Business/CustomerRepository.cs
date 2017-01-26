using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class CustomerRepository
    {
        public List<Customer> customerList { get; private set; }

        public CustomerRepository()
        {
            customerList = new List<Customer>();
        }
        public void AddCustomerToList(Customer newCustomer)
        {
            customerList.Add(newCustomer);
        }
        public List<Customer> GetCustomerList()
        {
            return customerList;
        }
        
        public void CreateCustomer(string lastName, string firstName, string address, string phoneNumber)
        {
            Customer newCust = new Customer(lastName, firstName, address, phoneNumber);
            SaveToDB(newCust);

        }
        public void SaveToDB(Customer newCust)
        {
            DatabaseLayer.DatabaseFacade.GetInstance.NewCustomer(newCust);
        }
    }
}
