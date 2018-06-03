using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-96 Override ToString
    /// </summary>
    class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + ' ' + LastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine(p);
        }
    }
}
