using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-95 Rethrowing an exception
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SomeOperation();
            }
            catch(Exception logEx)
            {
                Log(logEx);
                throw;
            }
        }

        private static void SomeOperation()
        {
            throw new NotImplementedException();
        }

        private static void Log(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
