using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-85 Using WeakReference
    /// </summary>
    class Program
    {
        static WeakReference data;

        public static void Run()
        {
            object result = GetData();
            result = GetData();
        }

        private static object GetData()
        {
            if(data == null)
            {
                data = new WeakReference(LoadLargeList());
            }

            if(data.Target == null)
            {
                data.Target = LoadLargeList();
            }

            return data.Target;
        }

        private static object LoadLargeList()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
        }
    }
}
