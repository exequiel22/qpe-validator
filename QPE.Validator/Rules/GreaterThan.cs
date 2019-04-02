using System;

namespace QPE.Validator
{
    internal class GreaterThan : IRule
    {
        private readonly double value;

        public GreaterThan(double value)
        {
            this.value = value;
        }

        public string Name => "GreaterThan";

        public bool IsValid(object value)
        {
            return Convert.ToDouble(value) > this.value;
        }
    }
}