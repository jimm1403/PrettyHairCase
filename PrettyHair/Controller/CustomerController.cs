using DatabaseLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    class CustomerController
    {
        //Fields
        private static CustomerController instance;

        //Properties
        public Customer CurrentCustomer { get; private set; }
        public List<Customer> custList { get; private set; }

        //Constructor
        private CustomerController()
        {
            CurrentCustomer = null;
        }

        //Methods
        public static CustomerController GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerController();
            }
            return instance;
        }

        public void AddCustomer()
        {
            Customer customer = new Customer();
            CurrentCustomer = customer;
            DatabaseFacade.GetInstance.NewCustomer(CurrentCustomer);
        }
        public List<Customer> ShowCustomer(List<Customer> dbCustList)
        {
            custList = dbCustList;
            return custList;
        }
    }
}
