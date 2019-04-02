using System;

namespace QPE.Validator
{
    internal class BeforeOrEqualDate : IRule
    {
        private DateTime date;

        public BeforeOrEqualDate(DateTime date)
        {
            this.date = date;
        }

        public string Name => "BeforeOrEqualDate";


        public string SuccessMessage => throw new NotImplementedException();

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid(object value)
        {
            DateTime? valueDate = value as DateTime?;
            return valueDate <= date;
        }
    }
}