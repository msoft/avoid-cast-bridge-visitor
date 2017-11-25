using System;

namespace BridgeVisitor
{
    public interface IRestServiceConfiguration : IConnectionConfiguration
    {
        string RestMethod { get; }
        string RestFormat { get; }
    }

    public class RestServiceConfiguration: ConnectionConfiguration, IRestServiceConfiguration 
    { 
        public string RestMethod { get; set; }
        public string RestFormat { get; set; }
    
        public override void VisitRestServiceConfigurationConsumer(IRestServiceConfigurationConsumer configurationConsumer) 
        { 
            configurationConsumer.AcceptConfiguration(this); 
        } 
    } 
}