namespace QPE.Validator
{
    internal sealed class Required : IRule
    {
        public Required()
        {


        }

        public string Name => "Required";

        public string ErrorMessage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public bool IsValid(object value)
        {
            if (value != null)
            {
                if (value is string)
                    return !string.IsNullOrEmpty(value.ToString()) && !string.IsNullOrWhiteSpace(value.ToString());
                else
                    return true;
            }
            return false;
        }
    }
}