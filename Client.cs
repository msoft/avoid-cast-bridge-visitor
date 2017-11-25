
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
}
