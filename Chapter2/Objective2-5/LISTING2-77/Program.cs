using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-77 Creating a Func type with a lambda
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine(addFunc(2, 3));
        }
    }
}
