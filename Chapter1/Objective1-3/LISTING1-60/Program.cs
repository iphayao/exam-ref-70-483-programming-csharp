using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-60 The conditional operator
    /// </summary>
    class Program
    {
        private static int GetValue(bool p)
        {
            /*if (p)
                return 1;
            else
                return 0;*/

            return p ? 1 : 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetValue(true));
        }
    }
}
