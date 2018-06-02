using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-27 Using the 'is' and 'as' operators
    /// </summary>
    class Program
    {
        void OpenConnection(DbConnection connection)
        {
            if(connection is SqlConnection)
            {
                // run some special code
            }
        }

        void LogStream(Stream stream)
        {
            MemoryStream memoryStream = stream as MemoryStream;
            if(memoryStream != null)
            {
                // ....
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
