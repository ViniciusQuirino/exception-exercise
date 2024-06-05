using System;

namespace exception_exercise.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {
        }
    }
}