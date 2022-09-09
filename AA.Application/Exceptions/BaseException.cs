namespace AA.Application.Exceptions
{
    public class BaseException : Exception
    {
        protected BaseException(string message) : base(message)
        { }
    }
}
