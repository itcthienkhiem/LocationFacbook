﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/wcfCheckinPlaces")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        test.ServiceReference1.CompositeType GetDataUsingDataContract(test.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<test.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(test.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccessTokenFromCode", ReplyAction="http://tempuri.org/IService1/GetAccessTokenFromCodeResponse")]
        string GetAccessTokenFromCode(string AppID, string AppSecret);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccessTokenFromCode", ReplyAction="http://tempuri.org/IService1/GetAccessTokenFromCodeResponse")]
        System.Threading.Tasks.Task<string> GetAccessTokenFromCodeAsync(string AppID, string AppSecret);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getFoodFacebook", ReplyAction="http://tempuri.org/IService1/getFoodFacebookResponse")]
        string getFoodFacebook(string access_token, string latitude, string longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getFoodFacebook", ReplyAction="http://tempuri.org/IService1/getFoodFacebookResponse")]
        System.Threading.Tasks.Task<string> getFoodFacebookAsync(string access_token, string latitude, string longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAlbumsImages", ReplyAction="http://tempuri.org/IService1/getAllAlbumsImagesResponse")]
        string getAllAlbumsImages(string AppID, string AppSecret);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAlbumsImages", ReplyAction="http://tempuri.org/IService1/getAllAlbumsImagesResponse")]
        System.Threading.Tasks.Task<string> getAllAlbumsImagesAsync(string AppID, string AppSecret);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllPhotoImages", ReplyAction="http://tempuri.org/IService1/getAllPhotoImagesResponse")]
        string getAllPhotoImages(string access_token, string albumID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllPhotoImages", ReplyAction="http://tempuri.org/IService1/getAllPhotoImagesResponse")]
        System.Threading.Tasks.Task<string> getAllPhotoImagesAsync(string access_token, string albumID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAlbums", ReplyAction="http://tempuri.org/IService1/getAllAlbumsResponse")]
        string getAllAlbums(string access_token, string locationID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAlbums", ReplyAction="http://tempuri.org/IService1/getAllAlbumsResponse")]
        System.Threading.Tasks.Task<string> getAllAlbumsAsync(string access_token, string locationID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : test.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<test.ServiceReference1.IService1>, test.ServiceReference1.IService1 {
        
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
        
        public test.ServiceReference1.CompositeType GetDataUsingDataContract(test.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<test.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(test.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string GetAccessTokenFromCode(string AppID, string AppSecret) {
            return base.Channel.GetAccessTokenFromCode(AppID, AppSecret);
        }
        
        public System.Threading.Tasks.Task<string> GetAccessTokenFromCodeAsync(string AppID, string AppSecret) {
            return base.Channel.GetAccessTokenFromCodeAsync(AppID, AppSecret);
        }
        
        public string getFoodFacebook(string access_token, string latitude, string longitude) {
            return base.Channel.getFoodFacebook(access_token, latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<string> getFoodFacebookAsync(string access_token, string latitude, string longitude) {
            return base.Channel.getFoodFacebookAsync(access_token, latitude, longitude);
        }
        
        public string getAllAlbumsImages(string AppID, string AppSecret) {
            return base.Channel.getAllAlbumsImages(AppID, AppSecret);
        }
        
        public System.Threading.Tasks.Task<string> getAllAlbumsImagesAsync(string AppID, string AppSecret) {
            return base.Channel.getAllAlbumsImagesAsync(AppID, AppSecret);
        }
        
        public string getAllPhotoImages(string access_token, string albumID) {
            return base.Channel.getAllPhotoImages(access_token, albumID);
        }
        
        public System.Threading.Tasks.Task<string> getAllPhotoImagesAsync(string access_token, string albumID) {
            return base.Channel.getAllPhotoImagesAsync(access_token, albumID);
        }
        
        public string getAllAlbums(string access_token, string locationID) {
            return base.Channel.getAllAlbums(access_token, locationID);
        }
        
        public System.Threading.Tasks.Task<string> getAllAlbumsAsync(string access_token, string locationID) {
            return base.Channel.getAllAlbumsAsync(access_token, locationID);
        }
    }
}
