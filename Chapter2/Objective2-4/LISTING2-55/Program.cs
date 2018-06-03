using System;
using System.Collections.Generic;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-55 Syntactic sugar of the foreach statment
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9 };
            using(List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                while(enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
        }
    }
}
