namespace AA.Application.Exceptions
{
    public class InvalidMapStringToUserException : BaseException
    {
        public InvalidMapStringToUserException(string line) : base($"Cannot map line: {line} to User object.")
        {
        }
    }
}
