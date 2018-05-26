using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-39 A potential problem with multithreaded code
    /// </summary>
    class Program
    {
        private static int _flag = 0;
        private static int _value = 0;

        public static void Thread1()
        {
            _value = 5;
            _value = 1;
        }

        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }

        static void Main(string[] args)
        {
        

        }
    }
}
