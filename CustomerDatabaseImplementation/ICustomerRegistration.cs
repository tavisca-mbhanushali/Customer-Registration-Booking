using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerDatabaseImplementation
{
    
     public interface ICustomerRegistration
    {
        void RegistarCustomer(string FirstName, string LastName, string EmailId, string PhoneNumber);
    }
}
