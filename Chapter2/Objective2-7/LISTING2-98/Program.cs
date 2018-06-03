using System;
using System.Globalization;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-98 Displaying a DateTime with different format strings
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2013, 4, 22);
            CultureInfo provider = new CultureInfo("en-US");

            Console.WriteLine(d.ToString("d", provider));
            Console.WriteLine(d.ToString("D", provider));
            Console.WriteLine(d.ToString("M", provider));
        }
    }
}
