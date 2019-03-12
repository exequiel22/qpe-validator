namespace QPE.Validator
{
    public class ValidatorError
    {
        private string errorMessage;

        public ValidatorError(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }

        public string Message { get; }
    }
}