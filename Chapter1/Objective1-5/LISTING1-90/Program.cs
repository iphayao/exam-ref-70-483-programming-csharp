using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-90 Catching different exception types
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                try
                {
                    int i = int.Parse(s);
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch(FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try agian", s);
                }
            }
        }
    }
}
