using AA.Application;
using AA.Presentation.Services;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection sc = new ServiceCollection();
sc.RegisterApplication();
sc.AddSingleton<IFileHandler, FileHandler>();

var serviceProvider = sc.BuildServiceProvider();
var fh = serviceProvider.GetService<IFileHandler>();

var users = fh.GetUsers(Path.Combine(".", "DataFiles", "data.csv"));
fh.WriteUsersWithSorting(Path.Combine(".", "DataFiles", $"{Guid.NewGuid().ToString()}.csv"), users);
