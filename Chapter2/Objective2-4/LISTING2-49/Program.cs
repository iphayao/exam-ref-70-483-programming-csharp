using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-49 Creating an abstract class
    /// </summary>
    abstract class Base
    {
        public virtual void MethodWithImplementation()
        {
            // Method with implementation
        }

        public abstract void AbstractMethod();
    }

    class Derived : Base
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("AbstractMethod in Derived class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Derived();
            b.AbstractMethod();
        }
    }
}
