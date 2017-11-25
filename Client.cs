
namespace BridgeVisitor
{
    public interface IData
    {

    }

    public interface IClient 
    { 
        IData FetchData(IConfigurationHandler configurationHandler); 
    } 


    public class DatabaseClient: IClient, IDatabaseConfigurationConsumer
    { 
        private string name;
        private string address;
        private string port;

        private string databaseName;
        private string userId; 
        private string password;

        public void AcceptConfiguration(IDatabaseConfiguration configuration) 
        { 
            this.name = configuration.Name;
            this.address = configuration.Address;
            this.port = configuration.Port;

            this.databaseName = configuration.DatabaseName; 
            this.userId = configuration.UserId; 
            this.password = configuration.Password; 
        }

        public IData FetchData(IConfigurationHandler configurationHandler) 
        { 
            configurationHandler.GetDatabaseConfiguration(this); 

            return null;
        } 
    }

    public class RestServiceClient: IClient, IRestServiceConfigurationConsumer
    { 
        private string name;
        private string address;
        private string port;

        private string restMethod; 
        private string restFormat; 

        public void AcceptConfiguration(IRestServiceConfiguration configuration) 
        { 
            this.name = configuration.Name;
            this.address = configuration.Address;
            this.port = configuration.Port;

            this.restMethod = configuration.RestMethod; 
            this.restFormat = configuration.RestFormat; 
        }

        public IData FetchData(IConfigurationHandler configurationHandler) 
        { 
            configurationHandler.GetRestServiceConfiguration(this);  
            
            return null;
        } 
    } 


    // public class DatabaseClient: IClient 
    // { 
    //     public IData FetchData(IConfigurationHandler configurationHandler) 
    //     { 
    //         string databaseName = configurationHandler.DatabaseName; 
    //         string userId = configurationHandler.UserId; 
    //         string password = configurationHandler.Password; 

    //         return null;
    //     } 
    // }

    // public class RestServiceClient: IClient 
    // { 
    //     public IData FetchData(IConfigurationHandler configurationHandler) 
    //     { 
    //         string restMethod = configurationHandler.RestMethod; 
    //         string format = configurationHandler.RestFormat; 
            
    //         return null;
    //     } 
    // } 

    // public class DatabaseClient: IClient 
    // { 
    //     public IData FetchData(IConnectionConfiguration configuration) 
    //     { 
    //         IDatabaseConfiguration databaseConfiguration = configuration as IDatabaseConfiguration; 
 
    //         // On accède aux membres spécifiques à la base de données: 
    //         string databaseName = databaseConfiguration.DatabaseName; 
    //         string userId = databaseConfiguration.UserId; 
    //         string password = databaseConfiguration.Password; 

    //         return null;
    //     } 
    // }

    // public class RestServiceClient: IClient 
    // { 
    //     public IData FetchData(IConnectionConfiguration configuration) 
    //     { 
    //         IRestServiceConfiguration restServiceConfiguration = configuration as IRestServiceConfiguration; 
    
    //         // On accède aux membres spécifiques au service REST: 
    //         string restMethod = restServiceConfiguration.RestMethod; 
    //         string format = restServiceConfiguration.Format; 
            
    //         return null;
    //     } 
    // }     
}
