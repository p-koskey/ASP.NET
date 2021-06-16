﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Restaurants", Namespace="http://schemas.datacontract.org/2004/07/RestaurantsModel")]
    [System.SerializableAttribute()]
    public partial class Restaurants : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Restaurant.ServiceReference1.CuisineType CuisineEnumField;
        
        private string CuisineTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Restaurant.ServiceReference1.CuisineType CuisineEnum {
            get {
                return this.CuisineEnumField;
            }
            set {
                if ((this.CuisineEnumField.Equals(value) != true)) {
                    this.CuisineEnumField = value;
                    this.RaisePropertyChanged("CuisineEnum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string CuisineType {
            get {
                return this.CuisineTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.CuisineTypeField, value) != true)) {
                    this.CuisineTypeField = value;
                    this.RaisePropertyChanged("CuisineType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CuisineType", Namespace="http://schemas.datacontract.org/2004/07/RestaurantsModel")]
    public enum CuisineType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Kenyan = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Italian = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Indian = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAll", ReplyAction="http://tempuri.org/IService1/GetAllResponse")]
        Restaurant.ServiceReference1.Restaurants[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAll", ReplyAction="http://tempuri.org/IService1/GetAllResponse")]
        System.Threading.Tasks.Task<Restaurant.ServiceReference1.Restaurants[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get", ReplyAction="http://tempuri.org/IService1/GetResponse")]
        Restaurant.ServiceReference1.Restaurants Get(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get", ReplyAction="http://tempuri.org/IService1/GetResponse")]
        System.Threading.Tasks.Task<Restaurant.ServiceReference1.Restaurants> GetAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        void Add(Restaurant.ServiceReference1.Restaurants entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Restaurant.ServiceReference1.Restaurants entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Remove", ReplyAction="http://tempuri.org/IService1/RemoveResponse")]
        void Remove(Restaurant.ServiceReference1.Restaurants entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Remove", ReplyAction="http://tempuri.org/IService1/RemoveResponse")]
        System.Threading.Tasks.Task RemoveAsync(Restaurant.ServiceReference1.Restaurants entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        void Update(Restaurant.ServiceReference1.Restaurants entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Restaurant.ServiceReference1.Restaurants entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Restaurant.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Restaurant.ServiceReference1.IService1>, Restaurant.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Restaurant.ServiceReference1.Restaurants[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Restaurant.ServiceReference1.Restaurants[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Restaurant.ServiceReference1.Restaurants Get(int Id) {
            return base.Channel.Get(Id);
        }
        
        public System.Threading.Tasks.Task<Restaurant.ServiceReference1.Restaurants> GetAsync(int Id) {
            return base.Channel.GetAsync(Id);
        }
        
        public void Add(Restaurant.ServiceReference1.Restaurants entity) {
            base.Channel.Add(entity);
        }
        
        public System.Threading.Tasks.Task AddAsync(Restaurant.ServiceReference1.Restaurants entity) {
            return base.Channel.AddAsync(entity);
        }
        
        public void Remove(Restaurant.ServiceReference1.Restaurants entity) {
            base.Channel.Remove(entity);
        }
        
        public System.Threading.Tasks.Task RemoveAsync(Restaurant.ServiceReference1.Restaurants entity) {
            return base.Channel.RemoveAsync(entity);
        }
        
        public void Update(Restaurant.ServiceReference1.Restaurants entity) {
            base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Restaurant.ServiceReference1.Restaurants entity) {
            return base.Channel.UpdateAsync(entity);
        }
    }
}