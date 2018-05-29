using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-18 Using the sealed keyword on a method
    /// </summary>
    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    class Derived : Base
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }

    class Derived2 : Derived
    {
        // This line would give a compile error
        /*public override int MyMethod()
        {
            return 1;
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived2 derived2 = new Derived2();
            Console.WriteLine(derived2.MyMethod());
        }
    }
}
