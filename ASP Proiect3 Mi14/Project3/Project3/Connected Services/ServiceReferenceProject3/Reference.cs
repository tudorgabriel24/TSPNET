﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceProject3
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceProject3.IMediaPerson")]
    public interface IMediaPerson
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/CreateMedia", ReplyAction="http://tempuri.org/InterfaceWCF/CreateMediaResponse")]
        System.Threading.Tasks.Task CreateMediaAsync(string type, string place, string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetMediaByPersonName", ReplyAction="http://tempuri.org/InterfaceWCF/GetMediaByPersonNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetMediaByPersonNameAsync(string name, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetMediaByLocation", ReplyAction="http://tempuri.org/InterfaceWCF/GetMediaByLocationResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetMediaByLocationAsync(string type, string place);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/AddPersonToMedia", ReplyAction="http://tempuri.org/InterfaceWCF/AddPersonToMediaResponse")]
        System.Threading.Tasks.Task AddPersonToMediaAsync(string name, string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/RemoveMedia", ReplyAction="http://tempuri.org/InterfaceWCF/RemoveMediaResponse")]
        System.Threading.Tasks.Task RemoveMediaAsync(string path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMediaPersonChannel : ServiceReferenceProject3.IMediaPerson, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MediaPersonClient : System.ServiceModel.ClientBase<ServiceReferenceProject3.IMediaPerson>, ServiceReferenceProject3.IMediaPerson
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MediaPersonClient() : 
                base(MediaPersonClient.GetDefaultBinding(), MediaPersonClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMediaPerson.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaPersonClient(EndpointConfiguration endpointConfiguration) : 
                base(MediaPersonClient.GetBindingForEndpoint(endpointConfiguration), MediaPersonClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaPersonClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MediaPersonClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaPersonClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MediaPersonClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaPersonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task CreateMediaAsync(string type, string place, string path)
        {
            return base.Channel.CreateMediaAsync(type, place, path);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetMediaByPersonNameAsync(string name, string type)
        {
            return base.Channel.GetMediaByPersonNameAsync(name, type);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetMediaByLocationAsync(string type, string place)
        {
            return base.Channel.GetMediaByLocationAsync(type, place);
        }
        
        public System.Threading.Tasks.Task AddPersonToMediaAsync(string name, string path)
        {
            return base.Channel.AddPersonToMediaAsync(name, path);
        }
        
        public System.Threading.Tasks.Task RemoveMediaAsync(string path)
        {
            return base.Channel.RemoveMediaAsync(path);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMediaPerson))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMediaPerson))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MediaPersonClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMediaPerson);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MediaPersonClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMediaPerson);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMediaPerson,
        }
    }
}
