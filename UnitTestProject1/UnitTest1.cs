using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerDatabaseImplementation;

namespace CustomerTest
{
    [TestClass]
    public class TestCustomer
    {
        [TestMethod]
        public void insert()
        {
            LinqToSqlDataContext dataContext = new LinqToSqlDataContext();
            int? cid = 0;
            dataContext.spInsertCustomer("Mayurersh", "Bhanushali", "mbhanushali@tavisca.com", "1234567890", ref cid);

           



            //CustomerRegistration customerRegistration = new CustomerRegistration();
            //customerRegistration.RegistarCustomer("Mayurersh", "Bhanushali", "mbhanushali@tavisca.com", "1234567890");
        }
    }
}
