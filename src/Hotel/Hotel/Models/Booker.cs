using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    internal class Booker
    {
        private List<Person> Guests { get; set; }
        private Suite Suite { get; set; }
        public int DaysBooked { get; private set; }

        public Booker(int daysBooked)
        {
            DaysBooked = daysBooked;
        }

        public void RegisterGuests(List<Person> persons)
        {
            Guests = persons ?? new List<Person>();
        }

        public void RegisterSuite(Suite suite)
        {
            if (suite == null)
            {
                throw new ArgumentNullException(nameof(suite), "Suite cannot be null.");
            }

            int guestsCount = GetTotalGuests();

            if (suite.Capacity > guestsCount)
            {
                throw new ArgumentException("Suite capacity must be greater than number of guests.", nameof(suite.Capacity));
            }
            Suite = suite;
        }

        public int GetTotalGuests()
        {
            if (Guests == null)
            {
                return 0;
            }
            return Guests.Count;
        }

        public decimal GetValueBooking()
        {
            if (Suite == null || DaysBooked <= 0)
            {
                return 0;
            }

            if ( DaysBooked >= 10 )
            {
                return Suite.DailyValue * DaysBooked * 0.9m; // 10% discount for bookings of 10 days or more
            }

            return Suite.DailyValue * DaysBooked;
        }
    }
}
