using AA.Application.Models;

namespace AA.Application.Services.Mapper
{
    internal class UserToStringMapper : IMapper<User, string>
    {
        public string Map(User source)
        {
            return source.ToString();
        }
    }
}
