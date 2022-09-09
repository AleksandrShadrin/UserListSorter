using AA.Application.Exceptions;
using AA.Application.Models;
using System.Globalization;

namespace AA.Application.Services.Mapper
{
    internal class StringToUserMapper : IMapper<string, User>
    {
        public User Map(string source)
        {
            var result = source.Split(";");

            if (result.Length == 2)
            {
                var isParsed = DateTime.TryParseExact(result[1], "yyyy_MM_dd",
                        CultureInfo.InvariantCulture, DateTimeStyles.None,
                        out var date);

                if (isParsed)
                {
                    return new(result[0], date);
                }
            }

            throw new InvalidMapStringToUserException(source);
        }
    }
}
