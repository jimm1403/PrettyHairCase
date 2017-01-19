using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseLayer;
using DomainLayer;

namespace PrettyHair
{
    public class BusinessFacade
    {
        private static BusinessFacade instance;

        public static BusinessFacade GetInstance()
        {
            if (instance == null)
            {
                instance = new BusinessFacade();
            }
            return instance;
        }
        public void AddCustomer(string lastName, string firstName, string address, string phoneNumber)
        {
            Customer newCust = new Customer(lastName, firstName, address, phoneNumber);
            DatabaseFacade.GetInstance.NewCustomer(newCust);
        }
        public List<Customer> ShowCustomer()
        {
            List<Customer> custList = new List<Customer>();
            custList.AddRange(DatabaseFacade.GetInstance.ShowCustomer());
            
            return custList;
        }
    }
}
