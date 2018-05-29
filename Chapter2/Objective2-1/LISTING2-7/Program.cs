using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-7 Using named and optional arguments
    /// </summary>
    class Program
    {
        void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {
            Console.WriteLine("MyMethod");
        }

        void CallingMethod()
        {
            MyMethod(1, thirdArgument: true);
        }

        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.CallingMethod();
        }
    }
}
