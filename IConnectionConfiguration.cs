using System;

namespace BridgeVisitor
{
    public interface IConnectionConfiguration
    {
        string Name { get; }
        string Address { get; }
        string Port { get; }

        void VisitDatabaseConfigurationConsumer(IDatabaseConfigurationConsumer configurationConsumer); 
    
        void VisitRestServiceConfigurationConsumer(IRestServiceConfigurationConsumer configurationConsumer);
    }


    public class ConnectionConfiguration : IConnectionConfiguration
    { 
        public string Name { get; }
        public string Address { get; }
        public string Port { get; }
    
        public virtual void VisitDatabaseConfigurationConsumer(IDatabaseConfigurationConsumer configurationConsumer) 
        {

        } 
    
        public virtual void VisitRestServiceConfigurationConsumer(IRestServiceConfigurationConsumer configurationConsumer) 
        {

        } 
    } 
}
