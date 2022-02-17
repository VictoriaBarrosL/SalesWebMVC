using System;
using System.Runtime.Serialization;

namespace SalesWebMVC.Controllers
{
    [Serializable]
    internal class DbConcurrencyExeption : Exception
    {
        public DbConcurrencyExeption()
        {
        }

        public DbConcurrencyExeption(string message) : base(message)
        {
        }

        public DbConcurrencyExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbConcurrencyExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}