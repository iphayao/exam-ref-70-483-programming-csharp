using System.Collections.Generic;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-43 Creating an interface with a generic type parameter
    /// </summary>
    interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
