using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class DatabaseFacade
    {
        private static string connectionString =
            "Server=ealdb1.eal.local; Database= ejl50_db; User= ejl50_usr; Password=Baz1nga50;";
        public void GetCustomer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd2 = new SqlCommand("spGetCustomers", connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    //cmd2.Parameters.Add(new SqlParameter("@ZipCode", "5000"));

                    SqlDataReader reader = cmd2.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string custLastName = reader["CustLastName"].ToString();
                            string custFirstName = reader["CustFirstName"].ToString();
                            string custAddress = reader["CustAddress"].ToString();
                            string custPhone = reader["CustPhoneNumber"].ToString();
                            Customer customerGet = new Customer(custLastName, custFirstName, custAddress, custPhone);
                            CustomerRepository custRepo = new CustomerRepository();
                            custRepo.AddCustomerToList(customerGet);
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("UPS " + e.Message);
                    Console.ReadKey();
                }
            }
        }
        public void InsertCustomer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd1 = new SqlCommand("spInsertCustomer", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    Console.WriteLine("Enter last name:");
                    string lastName = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@CustLastName", lastName));
                    Console.WriteLine("Enter first name:");
                    string firstName = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@CustFirstName", firstName));
                    Console.WriteLine("Enter address:");
                    string address = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@CustAddress", address));
                    Console.WriteLine("Enter phone number:");
                    string phone = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@CustPhoneNumber", phone));

                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("UPS " + e.Message);
                    Console.ReadKey();
                }

            }

        }
    }
}
