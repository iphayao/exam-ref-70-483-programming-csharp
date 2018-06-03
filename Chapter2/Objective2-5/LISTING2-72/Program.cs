using System;
using System.Reflection;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-72 Getting the value of a field through relection
    /// </summary>
    class Program
    {
        static void DumpObject(Object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach(FieldInfo field in fields)
            {
                if(field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }

        }

        static void Main(string[] args)
        {
        }
    }
}
