﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumindoServico.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/PassagensWCF")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cpfField;
        
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
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cpf {
            get {
                return this.cpfField;
            }
            set {
                if ((object.ReferenceEquals(this.cpfField, value) != true)) {
                    this.cpfField = value;
                    this.RaisePropertyChanged("cpf");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/buscar", ReplyAction="http://tempuri.org/IClienteService/buscarResponse")]
        ConsumindoServico.ServiceReference1.Cliente buscar(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/buscar", ReplyAction="http://tempuri.org/IClienteService/buscarResponse")]
        System.Threading.Tasks.Task<ConsumindoServico.ServiceReference1.Cliente> buscarAsync(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Add", ReplyAction="http://tempuri.org/IClienteService/AddResponse")]
        void Add(ConsumindoServico.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Add", ReplyAction="http://tempuri.org/IClienteService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(ConsumindoServico.ServiceReference1.Cliente c);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : ConsumindoServico.ServiceReference1.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<ConsumindoServico.ServiceReference1.IClienteService>, ConsumindoServico.ServiceReference1.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsumindoServico.ServiceReference1.Cliente buscar(string nome) {
            return base.Channel.buscar(nome);
        }
        
        public System.Threading.Tasks.Task<ConsumindoServico.ServiceReference1.Cliente> buscarAsync(string nome) {
            return base.Channel.buscarAsync(nome);
        }
        
        public void Add(ConsumindoServico.ServiceReference1.Cliente c) {
            base.Channel.Add(c);
        }
        
        public System.Threading.Tasks.Task AddAsync(ConsumindoServico.ServiceReference1.Cliente c) {
            return base.Channel.AddAsync(c);
        }
    }
}
