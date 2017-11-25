using System;

namespace BridgeVisitor
{
    public interface IDatabaseConfiguration : IConnectionConfiguration
    {
        string DatabaseName { get; }
        string UserId { get; }
        string Password { get; }

    }

    public interface IAzureConfiguration : IConnectionConfiguration
    {
        string Provider { get; }
        string InitialCatalog { get; }
        string DataSource { get; }
        string UserId { get; }
        string Password { get; }
    }

    public class DatabaseConfiguration : ConnectionConfiguration, IDatabaseConfiguration 
    { 
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    
        public string Provider { get; set; }
        public string InitialCatalog { get; set;}
        public string DataSource { get; set;}

        public override void VisitDatabaseConfigurationConsumer(IDatabaseConfigurationConsumer configurationConsumer) 
        { 
            configurationConsumer.AcceptConfiguration(this); 
        } 
    }
}