using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-26 Using the built-in Convert and Parse methods
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool success = int.TryParse("42", out value);
        }
    }
}
