
namespace BridgeVisitor
{
    public interface IConfigurationHandler
    { 
        void GetDatabaseConfiguration(IDatabaseConfigurationConsumer configurationConsumer);    
        void GetRestServiceConfiguration(IRestServiceConfigurationConsumer configurationConsumer);
        



        // // Membres de IDatabaseConnectionConfiguration 
        // string DatabaseName { get; } 
        // string UserId { get; } 
        // string Password { get; } 
    
        // // Membres de IRestServiceConfiguration 
        // string RestMethod { get; } 
        // string RestFormat { get; } 
    } 


    public class ConfigurationHandler : IConfigurationHandler
    { 
        private IConnectionConfiguration databaseConfiguration; 
        private IConnectionConfiguration restServiceConfiguration; 
 
        public ConfigurationHandler(
            IConnectionConfiguration databaseConfiguration, 
            IConnectionConfiguration restServiceConfiguration) 
        { 
            this.databaseConfiguration = databaseConfiguration; 
            this.restServiceConfiguration = restServiceConfiguration; 
        }  
 
        public void GetDatabaseConfiguration(IDatabaseConfigurationConsumer configurationConsumer) 
        { 
            this.databaseConfiguration.VisitDatabaseConfigurationConsumer(configurationConsumer); 
        } 
    
        public void GetRestServiceConfiguration(IRestServiceConfigurationConsumer configurationConsumer) 
        { 
            this.restServiceConfiguration.VisitRestServiceConfigurationConsumer(configurationConsumer); 
        } 
    } 

    // public class ConfigurationHandler : IConfigurationHandler
    // { 
    //     private IDatabaseConfiguration databaseConfiguration; 
    //     private IRestServiceConfiguration restServiceConfiguration; 
    

    //     public ConfigurationHandler(
    //         IConnectionConfiguration databaseConfiguration, 
    //         IConnectionConfiguration restServiceConfiguration) 
    //     { 
    //         this.databaseConfiguration = databaseConfiguration as IDatabaseConfiguration; 
    //         this.restServiceConfiguration = restServiceConfiguration as IRestServiceConfiguration; 
    //     }  
    
    //     // Membres de IDatabaseConfiguration 
    //     public string DatabaseName { get { return this.databaseConfiguration.DatabaseName; } } 
    //     public string UserId { get { return this.databaseConfiguration.UserId; } } 
    //     public string Password { get { return this.databaseConfiguration.Password; } } 
    
    //     // Membres de IRestServiceConfiguration 
    //     public string RestMethod { get { return this.restServiceConfiguration.RestMethod; } } 
    //     public string RestFormat { get { return this.restServiceConfiguration.RestFormat; } } 
    // } 
}
