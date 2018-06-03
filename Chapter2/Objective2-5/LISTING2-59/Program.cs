using System.Diagnostics;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-59 Using multiple attribute
    /// </summary>
    class Program
    {
        [Conditional("Condition1"), Conditional("Condition2")]
        static void myMethod() { }

        static void Main(string[] args)
        {
        }
    }
}
