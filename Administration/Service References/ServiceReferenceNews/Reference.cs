﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Administration.ServiceReferenceNews {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
        public bool BoolValue {
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
        public string StringValue {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="News", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    public partial class News : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime date_modifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime date_publishedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool publishedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string textField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int userIdField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_modified {
            get {
                return this.date_modifiedField;
            }
            set {
                if ((this.date_modifiedField.Equals(value) != true)) {
                    this.date_modifiedField = value;
                    this.RaisePropertyChanged("date_modified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_published {
            get {
                return this.date_publishedField;
            }
            set {
                if ((this.date_publishedField.Equals(value) != true)) {
                    this.date_publishedField = value;
                    this.RaisePropertyChanged("date_published");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool published {
            get {
                return this.publishedField;
            }
            set {
                if ((this.publishedField.Equals(value) != true)) {
                    this.publishedField = value;
                    this.RaisePropertyChanged("published");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                if ((object.ReferenceEquals(this.textField, value) != true)) {
                    this.textField = value;
                    this.RaisePropertyChanged("text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Tutorial", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    public partial class Tutorial : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime date_modifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime date_publishedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool publishedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string textField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int userIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string videoField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_modified {
            get {
                return this.date_modifiedField;
            }
            set {
                if ((this.date_modifiedField.Equals(value) != true)) {
                    this.date_modifiedField = value;
                    this.RaisePropertyChanged("date_modified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_published {
            get {
                return this.date_publishedField;
            }
            set {
                if ((this.date_publishedField.Equals(value) != true)) {
                    this.date_publishedField = value;
                    this.RaisePropertyChanged("date_published");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int page {
            get {
                return this.pageField;
            }
            set {
                if ((this.pageField.Equals(value) != true)) {
                    this.pageField = value;
                    this.RaisePropertyChanged("page");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool published {
            get {
                return this.publishedField;
            }
            set {
                if ((this.publishedField.Equals(value) != true)) {
                    this.publishedField = value;
                    this.RaisePropertyChanged("published");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                if ((object.ReferenceEquals(this.textField, value) != true)) {
                    this.textField = value;
                    this.RaisePropertyChanged("text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string video {
            get {
                return this.videoField;
            }
            set {
                if ((object.ReferenceEquals(this.videoField, value) != true)) {
                    this.videoField = value;
                    this.RaisePropertyChanged("video");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceNews.INewsService")]
    public interface INewsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/INewsService/GetDataUsingDataContractResponse")]
        Administration.ServiceReferenceNews.CompositeType GetDataUsingDataContract(Administration.ServiceReferenceNews.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/INewsService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Administration.ServiceReferenceNews.CompositeType> GetDataUsingDataContractAsync(Administration.ServiceReferenceNews.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetNews", ReplyAction="http://tempuri.org/INewsService/GetNewsResponse")]
        System.Collections.Generic.List<Administration.ServiceReferenceNews.News> GetNews();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetNews", ReplyAction="http://tempuri.org/INewsService/GetNewsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Administration.ServiceReferenceNews.News>> GetNewsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetNewsById", ReplyAction="http://tempuri.org/INewsService/GetNewsByIdResponse")]
        Administration.ServiceReferenceNews.News GetNewsById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetNewsById", ReplyAction="http://tempuri.org/INewsService/GetNewsByIdResponse")]
        System.Threading.Tasks.Task<Administration.ServiceReferenceNews.News> GetNewsByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetTutorials", ReplyAction="http://tempuri.org/INewsService/GetTutorialsResponse")]
        System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial> GetTutorials();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetTutorials", ReplyAction="http://tempuri.org/INewsService/GetTutorialsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial>> GetTutorialsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetTutorialById", ReplyAction="http://tempuri.org/INewsService/GetTutorialByIdResponse")]
        System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial> GetTutorialById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetTutorialById", ReplyAction="http://tempuri.org/INewsService/GetTutorialByIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial>> GetTutorialByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetTutorialByIdAndPage", ReplyAction="http://tempuri.org/INewsService/GetTutorialByIdAndPageResponse")]
        Administration.ServiceReferenceNews.Tutorial GetTutorialByIdAndPage(string id, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetTutorialByIdAndPage", ReplyAction="http://tempuri.org/INewsService/GetTutorialByIdAndPageResponse")]
        System.Threading.Tasks.Task<Administration.ServiceReferenceNews.Tutorial> GetTutorialByIdAndPageAsync(string id, string page);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsServiceChannel : Administration.ServiceReferenceNews.INewsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsServiceClient : System.ServiceModel.ClientBase<Administration.ServiceReferenceNews.INewsService>, Administration.ServiceReferenceNews.INewsService {
        
        public NewsServiceClient() {
        }
        
        public NewsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Administration.ServiceReferenceNews.CompositeType GetDataUsingDataContract(Administration.ServiceReferenceNews.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Administration.ServiceReferenceNews.CompositeType> GetDataUsingDataContractAsync(Administration.ServiceReferenceNews.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public System.Collections.Generic.List<Administration.ServiceReferenceNews.News> GetNews() {
            return base.Channel.GetNews();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Administration.ServiceReferenceNews.News>> GetNewsAsync() {
            return base.Channel.GetNewsAsync();
        }
        
        public Administration.ServiceReferenceNews.News GetNewsById(string id) {
            return base.Channel.GetNewsById(id);
        }
        
        public System.Threading.Tasks.Task<Administration.ServiceReferenceNews.News> GetNewsByIdAsync(string id) {
            return base.Channel.GetNewsByIdAsync(id);
        }
        
        public System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial> GetTutorials() {
            return base.Channel.GetTutorials();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial>> GetTutorialsAsync() {
            return base.Channel.GetTutorialsAsync();
        }
        
        public System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial> GetTutorialById(string id) {
            return base.Channel.GetTutorialById(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Administration.ServiceReferenceNews.Tutorial>> GetTutorialByIdAsync(string id) {
            return base.Channel.GetTutorialByIdAsync(id);
        }
        
        public Administration.ServiceReferenceNews.Tutorial GetTutorialByIdAndPage(string id, string page) {
            return base.Channel.GetTutorialByIdAndPage(id, page);
        }
        
        public System.Threading.Tasks.Task<Administration.ServiceReferenceNews.Tutorial> GetTutorialByIdAndPageAsync(string id, string page) {
            return base.Channel.GetTutorialByIdAndPageAsync(id, page);
        }
    }
}
