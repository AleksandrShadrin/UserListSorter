using AA.Application.Models;

namespace AA.Application.Services
{
    public interface IFileWriter
    {
        void WriteToFile(string filePath, IEnumerable<User> data);
    }
}
