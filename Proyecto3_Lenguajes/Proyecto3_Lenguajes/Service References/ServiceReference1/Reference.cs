﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto3_Lenguajes.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseRepuesta", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Proyecto3_Lenguajes.ServiceReference1.Pago))]
    public partial class BaseRepuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mensajeField;
        
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
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.mensajeField, value) != true)) {
                    this.mensajeField = value;
                    this.RaisePropertyChanged("mensaje");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pago", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Pago : Proyecto3_Lenguajes.ServiceReference1.BaseRepuesta {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int montoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int monto {
            get {
                return this.montoField;
            }
            set {
                if ((this.montoField.Equals(value) != true)) {
                    this.montoField = value;
                    this.RaisePropertyChanged("monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWSpgos")]
    public interface IWSpgos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSpgos/pagoMatricula", ReplyAction="http://tempuri.org/IWSpgos/pagoMatriculaResponse")]
        Proyecto3_Lenguajes.ServiceReference1.Pago pagoMatricula(string usuario, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSpgos/pagoMatricula", ReplyAction="http://tempuri.org/IWSpgos/pagoMatriculaResponse")]
        System.Threading.Tasks.Task<Proyecto3_Lenguajes.ServiceReference1.Pago> pagoMatriculaAsync(string usuario, string Contrasena);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSpgosChannel : Proyecto3_Lenguajes.ServiceReference1.IWSpgos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSpgosClient : System.ServiceModel.ClientBase<Proyecto3_Lenguajes.ServiceReference1.IWSpgos>, Proyecto3_Lenguajes.ServiceReference1.IWSpgos {
        
        public WSpgosClient() {
        }
        
        public WSpgosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSpgosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSpgosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSpgosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Proyecto3_Lenguajes.ServiceReference1.Pago pagoMatricula(string usuario, string Contrasena) {
            return base.Channel.pagoMatricula(usuario, Contrasena);
        }
        
        public System.Threading.Tasks.Task<Proyecto3_Lenguajes.ServiceReference1.Pago> pagoMatriculaAsync(string usuario, string Contrasena) {
            return base.Channel.pagoMatriculaAsync(usuario, Contrasena);
        }
    }
}
