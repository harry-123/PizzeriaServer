namespace PizzeriaServer
{
    public class InvalidOrderException : ApplicationException
    {
        public string PropertyName { get; set; }

        public InvalidOrderException(string propertyName, string message) : base(message)
        {
            PropertyName = propertyName;
        }
    }
}
