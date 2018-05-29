using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-7 Using named and optional arguments
    /// </summary>
    class Program
    {
        public static void MethodWithoutAnyReturnValue()
        {
            /* Don't return any value to the caller */
        }

        public static int MethodWithReturnValue()
        {
            return 42;
        }

        static void Main(string[] args)
        {
            MethodWithoutAnyReturnValue();
            int result = MethodWithReturnValue();

            Console.WriteLine(result);
        }
    }
}
