using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-100 Creating a composite string formating
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            string result = string.Format("a: {0}, b: {1}", a, b);

            Console.WriteLine(result);
        }
    }
}
