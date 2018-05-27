using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-63 goto in a switch statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            switch(i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }

            // Display Case 1
        }
    }
}
