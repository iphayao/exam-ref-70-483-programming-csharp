using System.Collections.Generic;
using System.Linq;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-46 Inheriting from a base class
    /// </summary>
    interface IEntiry
    {
        int Id { get; }
    }

    class Repository<T> where T : IEntiry
    {
        protected IEnumerable<T> _elements;

        public Repository(IEnumerable<T> elements)
        {
            _elements = elements;
        }

        public T FindById(int id)
        {
            return _elements.SingleOrDefault(e => e.Id == id);
        }
    }

    class Order : IEntiry
    {
        public int Id { get; }
        // Other implementation detials omitted
        // ...
    }

    class OrderRepository : Repository<Order>
    {
        public OrderRepository(IEnumerable<Order> orders) : base(orders) { }

        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
        {
            List<Order> result = null;
            // Some filtering code
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
