using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace CustomerDatabaseImplementation
{
    public class CustomerRegistration : ICustomerRegistration
    {

        private const string DBName = "WCFHotelBookingMan";

        public void RegistarCustomer(string FirstName, string LastName, string EmailId, string PhoneNumber)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spInsertCustomer");
            //database.AddInParameter(dbcommand, "CustomerId", System.Data.DbType.Int64, CustomerId);
            database.AddInParameter(dbcommand, "FirstName", System.Data.DbType.String, FirstName);
            database.AddInParameter(dbcommand, "LastName", System.Data.DbType.String, LastName);
            database.AddInParameter(dbcommand, "EmailId", System.Data.DbType.String, EmailId);
            database.AddInParameter(dbcommand, "PhoneNumber", System.Data.DbType.String, PhoneNumber);
            database.ExecuteScalar(dbcommand);

            //return 0;
        }


    }
}
