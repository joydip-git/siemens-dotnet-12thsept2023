using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class InvalidAgeException : ApplicationException
    {
        DateTime exceptionLogTime;
        public InvalidAgeException() { }
        public InvalidAgeException(string message) : base(message)
        {

        }
        public InvalidAgeException(string message, DateTime loggedTime) : base(message)
        {
            exceptionLogTime = loggedTime;
        }
        public DateTime ExceptionLoggedTime => exceptionLogTime;
    }
}
