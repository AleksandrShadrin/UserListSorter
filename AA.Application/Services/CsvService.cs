using AA.Application.Exceptions;
using AA.Application.Models;
using AA.Application.Services.Mapper;

namespace AA.Application.Services
{
    internal class CsvService : IFileReader, IFileWriter
    {
        private readonly IMapper<string, User> stringToUserMapper;
        private readonly IMapper<User, string> userToStringMapper;
        public CsvService(IMapper<string, User> stringToUserMapper, IMapper<User, string> userToStringMapper)
        {
            this.stringToUserMapper = stringToUserMapper;
            this.userToStringMapper = userToStringMapper;
        }
        public IEnumerable<User> ReadUsersFromFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            
            if(!fileInfo.Exists)
                throw new FileDontExistException(filePath);

            using(var sr = fileInfo.OpenText())
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    yield return stringToUserMapper.Map(line);
                }
            }
        }

        public void WriteToFile(string filePath, IEnumerable<User> data)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                throw new FileAlreadyExistException(filePath);

            using (var sw = new StreamWriter(fileInfo.FullName))
            {
                foreach (var user in data)
                {
                    sw.WriteLine(userToStringMapper.Map(user));
                }
            }
        }
    }
}
