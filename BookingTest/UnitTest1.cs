using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomBookingDatabaseImplementation;
using CustomerDatabaseImplementation;

namespace BookingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void insertbooking()
        {
            var dataContext = new LinqToSqlDataContext();
            int? bid = 0;
            dataContext.spInsertBooking(10000, "GOA1", "GOA1_1", "2016-02-02","2016-03-03",2,ref bid);

        }
    }
}
