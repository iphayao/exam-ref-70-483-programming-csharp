using System;
using System.Collections.Generic;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-72 Changing items in a foreach
    /// </summary>
    class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        static void ConnotChangeForeachIterationVariable()
        {
            var people = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "Doe" },
                new Person() { FirstName = "Jane", LastName = "Doe" }
            };

            foreach(Person p in people)
            {
                p.LastName = "Changed";
                //p = new Person();
                Console.WriteLine(p.LastName);
            }
        }
        
        static void Main(string[] args)
        {
            ConnotChangeForeachIterationVariable();
        }
    }
}
