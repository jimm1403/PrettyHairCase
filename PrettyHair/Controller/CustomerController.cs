using DatabaseLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class CustomerController
    {
        //Fields
        private static CustomerController instance;
        private CustomerRepository custRepo;

        //Properties
        public Customer CurrentCustomer { get; private set; }
        public List<Customer> custList { get; private set; }

        //Constructor
        private CustomerController()
        {
            CurrentCustomer = null;
            custRepo = new CustomerRepository();
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
            custRepo.AddCustomerToList(customer);
        }
        public void saveToDB()
        {
            DatabaseFacade.GetInstance.NewCustomer(CurrentCustomer);
        }

        public List<Customer> GetCustomer()
        {
            //return custRepo.customerList;
            ShowCustomer();
            return custList;
        }

        public void ShowCustomer()
        {
            custList = DatabaseFacade.GetInstance.ShowCustomer();
        }
    }
}
