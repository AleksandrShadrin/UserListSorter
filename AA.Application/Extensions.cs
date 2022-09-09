using AA.Application.Models;
using AA.Application.Services;
using AA.Application.Services.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace AA.Application
{
    public static class Extensions
    {
        public static ServiceCollection RegisterApplication(this ServiceCollection services)
        {
            services.AddSingleton<IFileReader, CsvService>();
            services.AddSingleton<IFileWriter, CsvService>();
            services.AddSingleton<IUsersSorter, UsersSorter>();
            services.AddSingleton<IMapper<string, User>, StringToUserMapper>();
            services.AddSingleton<IMapper<User, string>, UserToStringMapper>();

            return services;
        }
    }
}
