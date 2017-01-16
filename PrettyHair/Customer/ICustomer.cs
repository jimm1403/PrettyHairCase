using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public interface ICustomer
    {
        string LastName { get; }
        string FirstName { get; }
        string Address { get; }
        string PhoneNumber { get; }
    }
}
