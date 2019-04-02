using System;

namespace QPE.Validator
{
    internal class As : IRule
    {
        private Type type;

        public As(Type type)
        {
            this.type = type;
        }

        public string Name => "TypeOf";

        public bool IsValid(object value)
        {
            try
            {
                Convert.ChangeType(value, type);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}