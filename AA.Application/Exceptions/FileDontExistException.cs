namespace AA.Application.Exceptions
{
    public class FileDontExistException : BaseException
    {
        public string Path { get; set; }
        public FileDontExistException(string path) : base($"File with path: '{path}' don't exist.")
        {
            Path = path;    
        }
    }
}
