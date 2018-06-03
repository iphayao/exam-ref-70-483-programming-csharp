using System;
using System.Globalization;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-97 Displaying a number with currency format string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new CultureInfo("en-US")));
        }
    }
}
