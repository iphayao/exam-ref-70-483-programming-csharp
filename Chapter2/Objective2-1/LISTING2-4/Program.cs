using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-4 Creating a method
    /// </summary>
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int result = cal.Add(10, 20);

            Console.WriteLine(result);
        }
    }
}
