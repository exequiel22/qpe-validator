using System;

namespace QPE.Validator
{
    internal class DateRule : IRule
    {
        public string Name => "Date";


        public string SuccessMessage => throw new System.NotImplementedException();

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid(object value) => value != null ? DateTime.TryParse(value.ToString(), out _) : false;

    }
}