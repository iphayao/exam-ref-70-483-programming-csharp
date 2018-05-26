using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-38 Generated code form a lock statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            object gate = new object();
            bool _lockTaken = false;
            
            try
            {
                Monitor.Enter(gate, ref _lockTaken);
            }
            finally
            {
                if (_lockTaken)
                    Monitor.Exit(gate);
            }
        }
    }
}
