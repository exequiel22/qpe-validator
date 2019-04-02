using System;
using System.Runtime.Serialization;

namespace QPE.Validator
{
    [Serializable]
    internal class InvalidRuleExpressionException : Exception
    {
        public InvalidRuleExpressionException()
        {
        }

        public InvalidRuleExpressionException(string message) : base(message)
        {
        }

        public InvalidRuleExpressionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidRuleExpressionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}