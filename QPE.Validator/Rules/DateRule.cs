using System;

namespace QPE.Validator
{
    internal class DateRule : IRule
    {
        public string Name => "Date";

        public bool IsValid(object value) => value != null ? DateTime.TryParse(value.ToString(), out _) : false;
    }
}