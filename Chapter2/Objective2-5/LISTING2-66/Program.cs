using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-66 Defining the targets for a custom attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class MyMethodAndParameterAttribute : Attribute
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
