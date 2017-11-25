namespace BridgeVisitor
{
    public interface IDatabaseConfigurationConsumer
    { 
        void AcceptConfiguration(IDatabaseConfiguration configuration); 
    } 

    public interface IRestServiceConfigurationConsumer
    { 
        void AcceptConfiguration(IRestServiceConfiguration configuration); 
    } 

    public interface IConfigurationVisitor 
    { 
        void VisitDatabaseConfigurationConsumer(IDatabaseConfigurationConsumer configurationConsumer); 
        void VisitRestServiceConfigurationConsumer(IRestServiceConfigurationConsumer configurationConsumer); 
    } 
}