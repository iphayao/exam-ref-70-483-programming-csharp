using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-56 Using multiple if/else statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            bool c = true;

            if(b)
            {
                Console.WriteLine("b is true");
            }
            else if(c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }
        }
    }
}
