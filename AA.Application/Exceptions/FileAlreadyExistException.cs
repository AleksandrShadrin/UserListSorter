namespace AA.Application.Exceptions
{
    public class FileAlreadyExistException:BaseException
    {
        public string Path { get; set; }
        public FileAlreadyExistException(string path) : base($"File with path: '{path}' already exist.")
        {
            Path = path;
        }
    }
}
