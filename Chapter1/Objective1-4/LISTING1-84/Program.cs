using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-84 Custom : EventArgs
    /// </summary>
    class Program
    {
        public class MyArgs : EventArgs
        {
            public int Value { get; set; }

            public MyArgs(int value)
            {
                Value = value;
            }
        }

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, new MyArgs(42));
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
        }

        static void Main(string[] args)
        {
            CreateAndRaise();
        }
    }
}
