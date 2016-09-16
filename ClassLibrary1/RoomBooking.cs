using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoomBooking
{
    public class BookingEntity
    {
        private int bookingId;
        private int hotelId;
        private int roomId;
        private int checkInDate;
        private int checkOutDate;
        private int noOfGuests;

        public int BookingId
        {
            get
            {
                return bookingId;
            }

            set
            {
                bookingId = value;
            }
        }

        public int HotelId
        {
            get
            {
                return hotelId;
            }

            set
            {
                hotelId = value;
            }
        }

        public int RoomId
        {
            get
            {
                return roomId;
            }

            set
            {
                roomId = value;
            }
        }

        public int CheckInDate
        {
            get
            {
                return checkInDate;
            }

            set
            {
                checkInDate = value;
            }
        }

        public int CheckOutDate
        {
            get
            {
                return checkOutDate;
            }

            set
            {
                checkOutDate = value;
            }
        }

        public int NoOfGuests
        {
            get
            {
                return noOfGuests;
            }

            set
            {
                noOfGuests = value;
            }
        }
    }
}
