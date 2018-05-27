using System;
using System.Runtime.ExceptionServices;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-97 Using ExceptionDispatchInfo.Throw
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch(FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if(possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}
