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

        public string ErrorMessage => throw new NotImplementedException();

        public string SuccessMessage => throw new NotImplementedException();

        public bool IsValid(object value)
        {
            DateTime? valueDate = value as DateTime?;
            return valueDate <= date;
        }
    }
}