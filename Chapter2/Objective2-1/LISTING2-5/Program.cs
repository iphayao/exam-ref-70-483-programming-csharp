using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-5 Passing a complete customers to a method
    /// </summary>
    class Program
    {
        public static Distance CalculateDistanceTo(Customer customer)
        {
            Distance result = new Distance(customer); // Some differetnt calculation that user customers
            return result;
        }

        static void Main(string[] args)
        {
            Distance distance = CalculateDistanceTo(new Customer());

            Console.WriteLine(distance);
        }
    }

    public class Customer
    {
    }

    public class Distance
    {
        Customer customer;

        public Distance(Customer customer)
        {
            this.customer = customer;
        }
    }
}
