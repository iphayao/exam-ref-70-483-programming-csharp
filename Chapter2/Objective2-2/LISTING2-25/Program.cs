using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-25 Using an implicit and explicit cast operator on a custom type
    /// </summary>
    class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int trancatedAmount = (int)m;

            Console.WriteLine(trancatedAmount);
        }
    }
}
