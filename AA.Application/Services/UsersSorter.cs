using AA.Application.Models;

namespace AA.Application.Services
{
    internal class UsersSorter : IUsersSorter
    {
        public IEnumerable<User> SortUsers(IEnumerable<User> data)
        {
            return data.OrderByDescending(user => user.Birthday.Date);
        }
    }
}
