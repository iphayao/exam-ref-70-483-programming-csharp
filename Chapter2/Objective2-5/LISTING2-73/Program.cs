using System;
using System.Reflection;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-73 Executing a method through reflection
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
        }
    }
}
