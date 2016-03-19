using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JGHolidays;
using NUnit.Framework;

namespace JGHolidaysTests
{
    [TestFixture]
    public class BookingTests
    {
        private IFlightBookingSystem flightBookingsystem;
        private IVillaBookingSystem villabookingsystem;

        [SetUp]
        public void Setup()
        {
            flightBookingsystem = new StubFlightBookingSystem();
            villabookingsystem = new StubVillabookingSystem();
        }

        [Test]
        public void  HolidayIsAvailableTest()
        {
            
            var HolidaySystem = new HolidaySystem(flightBookingsystem, villabookingsystem);

            bool IsHolidayAvailable = HolidaySystem.IsDatesAvailable("", "", 2, 2);

            
            Assert.AreEqual(true, IsHolidayAvailable);
        }
    }

    public class StubVillabookingSystem : IVillaBookingSystem
    {
        public string[] GetAvailableVillas(int week, int year)
        {
            throw new NotImplementedException();
        }
    }


    public class StubFlightBookingSystem : IFlightBookingSystem
    {
        public bool IsFlightAvailable(string departureAirport, string destAirpor, int week, int year)
        {
            return true;
        }
    }
}
