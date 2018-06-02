namespace Chapter2
{
    /// <summary>
    /// LISTING Implementing an implicit and explicit conversion operator
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
        }
    }
}
