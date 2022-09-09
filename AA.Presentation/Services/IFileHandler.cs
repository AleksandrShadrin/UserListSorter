using AA.Application.Models;

namespace AA.Presentation.Services
{
    public interface IFileHandler
    {
        IEnumerable<User> GetUsers(string filePath);
        void WriteUsersWithSorting(string filePath, IEnumerable<User> users);
    }
}
