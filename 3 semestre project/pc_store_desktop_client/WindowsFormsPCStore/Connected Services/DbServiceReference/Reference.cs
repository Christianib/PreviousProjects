﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsPCStore.DbServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DbConnectionError", Namespace="http://schemas.datacontract.org/2004/07/Exceptions")]
    [System.SerializableAttribute()]
    public partial class DbConnectionError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DbServiceReference.IDbService")]
    public interface IDbService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/TestConnection", ReplyAction="http://tempuri.org/IDbService/TestConnectionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsPCStore.DbServiceReference.DbConnectionError), Action="http://tempuri.org/IDbService/TestConnectionDbConnectionErrorFault", Name="DbConnectionError", Namespace="http://schemas.datacontract.org/2004/07/Exceptions")]
        void TestConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/TestConnection", ReplyAction="http://tempuri.org/IDbService/TestConnectionResponse")]
        System.Threading.Tasks.Task TestConnectionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDbServiceChannel : WindowsFormsPCStore.DbServiceReference.IDbService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DbServiceClient : System.ServiceModel.ClientBase<WindowsFormsPCStore.DbServiceReference.IDbService>, WindowsFormsPCStore.DbServiceReference.IDbService {
        
        public DbServiceClient() {
        }
        
        public DbServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DbServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void TestConnection() {
            base.Channel.TestConnection();
        }
        
        public System.Threading.Tasks.Task TestConnectionAsync() {
            return base.Channel.TestConnectionAsync();
        }
    }
}
