using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-96 Throwing a new exception that points to the original one
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProcessOrder();
            }
            catch(MessageQueueException ex)
            {
                throw new OrderProcessException("Error while processing order", ex);
            }
        }

        private static void ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class OrderProcessException : Exception
    {
        public OrderProcessException(string message, Exception innerException) : 
            base(message, innerException)
        {
        }
    }

    [Serializable]
    internal class MessageQueueException : Exception
    {
        public MessageQueueException()
        {
        }
    }
}
