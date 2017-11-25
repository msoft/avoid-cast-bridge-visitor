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
}