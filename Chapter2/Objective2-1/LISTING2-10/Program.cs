using System.Collections.Generic;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-10 Creating collection such as a Deck class
    /// </summary>
    class Card { }

    class Deck
    {
        public ICollection<Card> Cards { get; private set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
