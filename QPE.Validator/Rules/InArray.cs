using System;

namespace QPE.Validator
{
    internal class InArray : IRule
    {
        private object[] values;

        public InArray(object[] values)
        {
            this.values = values;
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