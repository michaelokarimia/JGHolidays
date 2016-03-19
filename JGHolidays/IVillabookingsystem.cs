using System;
using System.Security.Cryptography.X509Certificates;

namespace JGHolidays
{
    public interface IVillaBookingSystem
    {
        string[] GetAvailableVillas(int week, int year);
    }
}