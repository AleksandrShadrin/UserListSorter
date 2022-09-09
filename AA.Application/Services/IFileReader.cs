using AA.Application.Models;

namespace AA.Application.Services
{
    public interface IFileReader
    {
        IEnumerable<User> ReadUsersFromFile(string filePath);
    }
}
