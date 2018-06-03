using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-67 Setting the AllowMultiple parameter of a custom attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class MyMultipleUsageAttribue : Attribute
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
