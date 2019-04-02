using System;

namespace QPE.Validator
{
    internal class BeforeDate : IRule
    {
        private readonly DateTime date;

        public BeforeDate(DateTime date)
        {
            this.date = date;
        }

        public string Name => "BeforeDate";

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string SuccessMessage => throw new NotImplementedException();

        public bool IsValid(object value)
        {
            DateTime? valueDate = value as DateTime?;
            return valueDate < date;
        }
    }
}