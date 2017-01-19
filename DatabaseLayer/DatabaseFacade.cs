using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DatabaseLayer;
using DomainLayer;

namespace DatabaseLayer
{
    public class DatabaseFacade
    {
        Database db;
        private static DatabaseFacade instance;
        public static DatabaseFacade GetInstance
        {
            get
            {    
                if (instance == null)
                {
                    instance = new DatabaseFacade();
                }
                return instance;
            }  
        }
        private DatabaseFacade()
        {
            db = new Database();
        }
        public void NewCustomer(Customer newCust)
        {
            db.InsertCustomer(newCust);
        }
        public List<Customer> ShowCustomer()
        {
            List<Customer> custList = db.GetCustomer();
            return custList;
        }
    }
}
