﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebshopWPF.WebshopService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebshopService.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/LoginCheck", ReplyAction="http://tempuri.org/IMyService/LoginCheckResponse")]
        bool LoginCheck(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/LoginCheck", ReplyAction="http://tempuri.org/IMyService/LoginCheckResponse")]
        System.Threading.Tasks.Task<bool> LoginCheckAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/RegisterCheck", ReplyAction="http://tempuri.org/IMyService/RegisterCheckResponse")]
        string RegisterCheck(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/RegisterCheck", ReplyAction="http://tempuri.org/IMyService/RegisterCheckResponse")]
        System.Threading.Tasks.Task<string> RegisterCheckAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : WebshopWPF.WebshopService.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<WebshopWPF.WebshopService.IMyService>, WebshopWPF.WebshopService.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool LoginCheck(string username, string password) {
            return base.Channel.LoginCheck(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginCheckAsync(string username, string password) {
            return base.Channel.LoginCheckAsync(username, password);
        }
        
        public string RegisterCheck(string username) {
            return base.Channel.RegisterCheck(username);
        }
        
        public System.Threading.Tasks.Task<string> RegisterCheckAsync(string username) {
            return base.Channel.RegisterCheckAsync(username);
        }
    }
}
