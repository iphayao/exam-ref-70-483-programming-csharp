using System;

namespace Chapter2
{
    class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException();
                _firstName = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
