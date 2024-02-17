using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.Patterns
{
    public abstract class Vehicle { }

    public class Car : Vehicle { }  

    public class Truck : Vehicle { }

    public class Cart : Vehicle { }

    public static class TollCalculator
    {
        public static decimal CalculateToll(this Vehicle vehicle)
        {
            return vehicle switch
            {
                Car => 2.00m,
                Truck => 7.50m,
                null => throw new ArgumentNullException(nameof(vehicle)),
                _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle)),
            };
        }
    }
}
