using AA.Application.Models;

namespace AA.Application.Services
{
    public interface IUsersSorter
    {
        IEnumerable<User> SortUsers(IEnumerable<User> data);
    }
}
