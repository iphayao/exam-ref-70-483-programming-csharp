using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-82 Using an Action to expose an event
    /// </summary>
    class Program
    {
        public class Pub
        {
            public Action OnChange { get; set; }

            public void Raise()
            {
                if(OnChange != null)
                {
                    OnChange();
                }
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }

        static void Main(string[] args)
        {
            CreateAndRaise();
        }
    }
}
