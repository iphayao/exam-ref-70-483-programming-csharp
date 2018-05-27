using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-53 An if statement with code block
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            if(b)
            {
                Console.WriteLine("Both these lines");
                Console.WriteLine("Will be executed");
            }
        }
    }
}
