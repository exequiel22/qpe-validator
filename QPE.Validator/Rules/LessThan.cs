using System;

namespace QPE.Validator
{
    internal class LessThan : IRule
    {
        private readonly double value;

        public LessThan(double value)
        {
            this.value = value;
        }

        public string Name => "LessThan";

        public bool IsValid(object value)
        {
            return Convert.ToDouble(value) < this.value;
        }
    }
}