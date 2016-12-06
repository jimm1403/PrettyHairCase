using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class Customer
    {
        //Variables
        //static int nextId = 1;

        //int id;
        string lastName;
        string firstName;
        string address;
        string phoneNumber;
        //Constructor
        public Customer()
        {

        }
        public Customer(string lastName, string firstName, string address, string phoneNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            //id = nextId++;
        }
        //Methods
        //public int GetId()
        //{
        //    return id;
        //}
        public override string ToString()
        {
            return lastName + ", " + firstName + ", " + address + ", " + phoneNumber;
        }
    }
}
