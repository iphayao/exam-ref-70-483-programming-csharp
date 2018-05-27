using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-83 Using the event keyword
    /// </summary>
    class Program
    {
        public class Pub
        {
            public event Action Onchange = delegate { };

            public void Raise()
            {
                Onchange();
            }
        }

        public static void CreateAndRise()
        {
            Pub p = new Pub();
            p.Onchange += () => Console.WriteLine("Event raised to method");
            p.Raise();
        }

        static void Main(string[] args)
        {
            CreateAndRise();
        }
    }
}
