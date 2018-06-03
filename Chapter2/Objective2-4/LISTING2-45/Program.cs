using System.Collections.Generic;
using System.Linq;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-45 Creating a base class
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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
