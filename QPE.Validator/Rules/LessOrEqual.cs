using System;

namespace QPE.Validator
{
    internal class LessOrEqual : IRule
    {
        private double value;

        public LessOrEqual(double value)
        {
            this.value = value;
        }

        public string Name => "LessOrEqual";

        public bool IsValid(object value)
        {
            return Convert.ToDouble(value) <= this.value;
        }
    }
}