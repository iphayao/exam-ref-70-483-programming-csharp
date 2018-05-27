using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-89 Catching a FormatException
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                try
                {
                    int i = int.Parse(s);
                }
                catch(FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
            }
        }
    }
}
