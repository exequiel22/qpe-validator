namespace QPE.Validator
{
    internal sealed class Required : IRule
    {
        public Required()
        {
        }

        public Required(string displayFieldName)
        {
            DisplayFieldName = displayFieldName;
        }

        public string DisplayFieldName { get; set; }
        public string ErrorMessage => $"El campo {DisplayFieldName ?? ""} es un campo obligatorio.";
        public string Name => "Required";
        public string SuccessMessage => $"OK";

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