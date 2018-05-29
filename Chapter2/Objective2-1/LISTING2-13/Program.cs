using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-13 Generic Nullable<T> implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    struct Nullable<T> where T : struct
    {
        private bool hasValue;
        private T value;

        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        public bool HasValue { get { return this.hasValue; } }

        public T Value
        {
            get
            {
                if (!this.HasValue) throw new ArgumentException();
                return this.value;
            }
        }

        public T GetValueOrDefault()
        {
            return this.value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> nullWithValue = new Nullable<int>(45);
            Nullable<int> nullWihtoutValue = new Nullable<int>();

            Console.WriteLine("Value is {0}", nullWithValue.Value);

            try
            {
                Console.WriteLine("Value is {0}", nullWihtoutValue.Value);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occured with message: {0}", e.Message);
            }

        }
    }
}
