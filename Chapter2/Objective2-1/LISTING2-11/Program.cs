using System.Collections.Generic;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-11 Adding a constructor to your type
    /// </summary>
    class Card { }

    class Deck
    {
        private int _maximumNumberOfCards;

        public List<Card> Cards { get; set; }

        public Deck(int maximumNumberOfCards)
        {
            this._maximumNumberOfCards = maximumNumberOfCards;
            Cards = new List<Card>();
        }

        // Rest of the class
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
