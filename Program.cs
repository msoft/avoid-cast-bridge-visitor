using System;

namespace BridgeVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IConnectionConfiguration databaseConfiguration = new DatabaseConfiguration{ 
                DatabaseName = "MyDataBase",
                UserId = "User1",
                Password = "MyPassword"
            };

            IConnectionConfiguration restServiceConfiguration = new RestServiceConfiguration{
                RestMethod = "GET",
                RestFormat = "json"
            };

            IConfigurationHandler configurationHandler = new ConfigurationHandler(
                databaseConfiguration, restServiceConfiguration);

            DatabaseClient databaseClient = new DatabaseClient();
            databaseClient.FetchData(configurationHandler);

            RestServiceClient restServiceClient = new RestServiceClient();
            restServiceClient.FetchData(configurationHandler);
        }
    }
}
