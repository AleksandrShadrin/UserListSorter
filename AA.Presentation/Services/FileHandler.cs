using AA.Application.Exceptions;
using AA.Application.Models;
using AA.Application.Services;

namespace AA.Presentation.Services
{
    public class FileHandler : IFileHandler
    {
        private readonly IFileReader _reader;
        private readonly IFileWriter _writer;
        private readonly IUsersSorter _usersSorter;
        public FileHandler(IFileReader fileReader, IFileWriter fileWriter, IUsersSorter usersSorter)
        {
            _reader = fileReader;
            _writer = fileWriter;
            _usersSorter = usersSorter;
        }
        public IEnumerable<User> GetUsers(string filePath)
        {
            try
            {
                return _reader.ReadUsersFromFile(filePath);
            }
            catch (BaseException ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<User>();
            }

        }

        public void WriteUsersWithSorting(string filePath, IEnumerable<User> users)
        {
            try
            {
                _writer.WriteToFile(filePath, _usersSorter.SortUsers(users));
            }
            catch (BaseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
