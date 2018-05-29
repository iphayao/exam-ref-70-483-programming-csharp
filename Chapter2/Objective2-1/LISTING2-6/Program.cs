using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-6 Passing only an address to a method
    /// </summary>
    class Program
    {
        public static Distance CalculateDistanceTo(Address customer)
        {
            Distance result = new Distance(customer); // Some differetnt calculation that user address
            return result;
        }

        static void Main(string[] args)
        {
            Distance distance = CalculateDistanceTo(new Address());

            Console.WriteLine(distance);
        }
    }

    public class Address
    {
    }

    public class Distance
    {
        Address address;

        public Distance(Address address)
        {
            this.address = address;
        }
    }
}
