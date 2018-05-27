using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-48 Short-circuiting the OR operator
    /// </summary>
    class Program
    {
        public static void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
        }

        public static bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }

        static void Main(string[] args)
        {
            OrShortCircuit();
        }
    }
}
