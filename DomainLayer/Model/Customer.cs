using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainLayer
{
    public class Customer
    {
        //Variables
        string lastName;
        string firstName;
        string address;
        string phoneNumber;

        //Properties
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

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
        }

        //Methods
        public override string ToString()
        {
            return lastName + ", " + firstName + ", " + address + ", " + phoneNumber;
        }
    }
}
