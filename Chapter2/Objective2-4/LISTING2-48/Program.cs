using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-48 Hiding a method with the new keyword
    /// </summary>
    class Base
    {
        public void Execute()
        {
            Console.WriteLine("Base.Execute");
        }
    }

    class Derived : Base
    {
        public new void Execute()
        {
            Console.WriteLine("Derived.Execute");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Execute();
            b = new Derived();
            b.Execute();
        }
    }
}
