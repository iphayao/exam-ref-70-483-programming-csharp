using System;
using System.Collections.Generic;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-73 The compiler-generated code for a foreach loop
    /// </summary>
    class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "Doe" },
                new Person() { FirstName = "Jane", LastName = "Doe" }
            };

            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while(e.MoveNext())
                {
                    v = e.Current;
                    Console.WriteLine(v.FirstName);
                }
            }
            finally
            {
                IDisposable d = e as IDisposable;
                if (d != null) d.Dispose();
            }
        }
    }
}
