﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Administration.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    [System.SerializableAttribute()]
    internal partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        internal bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    internal partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        internal string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticateUserRequest", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    internal partial class AuthenticateUserRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        internal string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorInformation", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Administration.ServiceReference1.GetNewsItemsResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Administration.ServiceReference1.AuthenticateUserResponse))]
    internal partial class ErrorInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ErroredField;
        
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
        internal bool Errored {
            get {
                return this.ErroredField;
            }
            set {
                if ((this.ErroredField.Equals(value) != true)) {
                    this.ErroredField = value;
                    this.RaisePropertyChanged("Errored");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Message {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetNewsItemsResponse", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    internal partial class GetNewsItemsResponse : Administration.ServiceReference1.ErrorInformation {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Administration.ServiceReference1.NewsItem[] NewstItemsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal Administration.ServiceReference1.NewsItem[] NewstItems {
            get {
                return this.NewstItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.NewstItemsField, value) != true)) {
                    this.NewstItemsField = value;
                    this.RaisePropertyChanged("NewstItems");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticateUserResponse", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    internal partial class AuthenticateUserResponse : Administration.ServiceReference1.ErrorInformation {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AuthenticatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Administration.ServiceReference1.Person PersonField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal bool Authenticated {
            get {
                return this.AuthenticatedField;
            }
            set {
                if ((this.AuthenticatedField.Equals(value) != true)) {
                    this.AuthenticatedField = value;
                    this.RaisePropertyChanged("Authenticated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal Administration.ServiceReference1.Person Person {
            get {
                return this.PersonField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonField, value) != true)) {
                    this.PersonField = value;
                    this.RaisePropertyChanged("Person");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NewsItem", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    internal partial class NewsItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PictureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
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
        internal byte[] Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    internal interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Administration.ServiceReference1.CompositeType GetDataUsingDataContract(Administration.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Administration.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Administration.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPerson", ReplyAction="http://tempuri.org/IService1/GetPersonResponse")]
        Administration.ServiceReference1.Person GetPerson(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPerson", ReplyAction="http://tempuri.org/IService1/GetPersonResponse")]
        System.Threading.Tasks.Task<Administration.ServiceReference1.Person> GetPersonAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AuthenticateUser", ReplyAction="http://tempuri.org/IService1/AuthenticateUserResponse")]
        Administration.ServiceReference1.AuthenticateUserResponse AuthenticateUser(Administration.ServiceReference1.AuthenticateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AuthenticateUser", ReplyAction="http://tempuri.org/IService1/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<Administration.ServiceReference1.AuthenticateUserResponse> AuthenticateUserAsync(Administration.ServiceReference1.AuthenticateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNewsItems", ReplyAction="http://tempuri.org/IService1/GetNewsItemsResponse")]
        Administration.ServiceReference1.GetNewsItemsResponse GetNewsItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNewsItems", ReplyAction="http://tempuri.org/IService1/GetNewsItemsResponse")]
        System.Threading.Tasks.Task<Administration.ServiceReference1.GetNewsItemsResponse> GetNewsItemsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface IService1Channel : Administration.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class Service1Client : System.ServiceModel.ClientBase<Administration.ServiceReference1.IService1>, Administration.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Administration.ServiceReference1.CompositeType GetDataUsingDataContract(Administration.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Administration.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Administration.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public Administration.ServiceReference1.Person GetPerson(string username) {
            return base.Channel.GetPerson(username);
        }
        
        public System.Threading.Tasks.Task<Administration.ServiceReference1.Person> GetPersonAsync(string username) {
            return base.Channel.GetPersonAsync(username);
        }
        
        public Administration.ServiceReference1.AuthenticateUserResponse AuthenticateUser(Administration.ServiceReference1.AuthenticateUserRequest request) {
            return base.Channel.AuthenticateUser(request);
        }
        
        public System.Threading.Tasks.Task<Administration.ServiceReference1.AuthenticateUserResponse> AuthenticateUserAsync(Administration.ServiceReference1.AuthenticateUserRequest request) {
            return base.Channel.AuthenticateUserAsync(request);
        }
        
        public Administration.ServiceReference1.GetNewsItemsResponse GetNewsItems() {
            return base.Channel.GetNewsItems();
        }
        
        public System.Threading.Tasks.Task<Administration.ServiceReference1.GetNewsItemsResponse> GetNewsItemsAsync() {
            return base.Channel.GetNewsItemsAsync();
        }
    }
}
