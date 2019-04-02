using System;
using System.Runtime.Serialization;

namespace QPE.Validator.Exceptions
{
    class RuleValidException : Exception
    {
        public RuleValidException()
        {
        }

        public RuleValidException(string message) : base(message)
        {
        }

        public RuleValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RuleValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
