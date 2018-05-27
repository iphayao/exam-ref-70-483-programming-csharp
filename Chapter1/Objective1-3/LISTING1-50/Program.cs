using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-50 Using the AND operator
    /// </summary>
    class Program
    {
        public static bool Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Process(null));       // Displays false
            Console.WriteLine(Process("hello"));    // Displays false
            Console.WriteLine(Process("vertex"));   // Displays true;
        }
    }
}
