using System;

namespace SalesWebMvc.Services.Exceptions {
    public class DbConsurrencyException : ApplicationException {
        public DbConsurrencyException(string message) : base(message)
        {
        }
    }
}
