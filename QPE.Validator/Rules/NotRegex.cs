using System;
using System.Text.RegularExpressions;

namespace QPE.Validator
{
    internal class NotRegex : IRule
    {
        private Regex regex;

        public NotRegex(Regex regex)
        {
            this.regex = regex;
        }

        public string Name => throw new System.NotImplementedException();

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string SuccessMessage => throw new System.NotImplementedException();

        public bool IsValid(object value)
        {
            throw new System.NotImplementedException();
        }
    }
}