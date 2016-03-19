namespace JGHolidays
{
    public interface IFlightBookingSystem
    {
        bool IsFlightAvailable(string departureAirport, string destAirpor, int week, int year);
    }

    public class FlightBookingSystem : IFlightBookingSystem
    {
        public bool IsFlightAvailable(string departureAirport, string destAirpor, int week, int year)
        {
            return false;
        }
    }
}