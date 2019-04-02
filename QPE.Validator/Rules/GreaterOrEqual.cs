using System;

namespace QPE.Validator
{
    internal class GreaterOrEqual : IRule
    {
        private readonly double value;

        public GreaterOrEqual(double value)
        {
            this.value = value;
        }

        public string Name => "GreaterOrEqual";

        public bool IsValid(object value)
        {
            return Convert.ToDouble(value) >= this.value;
        }
    }
}