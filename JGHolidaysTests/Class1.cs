using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JGHolidaysTests
{
    [TestFixture]
    public class FlightsBooking
    {
        private FlightBookingSystem flightBookingsystem;

        [SetUp]
        public void Setup()
        {
            flightBookingsystem = new FlightBookingSystem();
        }

        [Test]
        public void ReturnsIflightsAvailable()
        {
            
            var departureAirport = "LHR";
            var destAirpor = "PFO";
            var week = 26;
            var year = 20011;

            bool flightsAvailable = flightBookingsystem.IsFlightAvailable(departureAirport,destAirpor,week,year);
            Assert.AreEqual(true, flightsAvailable);
        }
    }

    internal class FlightBookingSystem
    {
        public bool IsFlightAvailable(string departureAirport, string destAirpor, int week, int year)
        {
            return false;
        }
    }
}
