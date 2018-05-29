using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-16 Creating an extension method
    /// </summary>
    public class Product
    {
        public decimal Prices { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Prices * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Prices = 10;

            Calculator calc = new Calculator();
            Console.WriteLine(calc.CalculateDiscount(p));
        }
    }
}
