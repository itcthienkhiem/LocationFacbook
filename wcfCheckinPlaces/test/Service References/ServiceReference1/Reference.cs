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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/wcfCheckinPlaces")]
    [System.SerializableAttribute()]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string countryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double latitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double longitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string stateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string streetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string zipField;
        
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
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country {
            get {
                return this.countryField;
            }
            set {
                if ((object.ReferenceEquals(this.countryField, value) != true)) {
                    this.countryField = value;
                    this.RaisePropertyChanged("country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fid {
            get {
                return this.fidField;
            }
            set {
                if ((object.ReferenceEquals(this.fidField, value) != true)) {
                    this.fidField = value;
                    this.RaisePropertyChanged("fid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double latitude {
            get {
                return this.latitudeField;
            }
            set {
                if ((this.latitudeField.Equals(value) != true)) {
                    this.latitudeField = value;
                    this.RaisePropertyChanged("latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double longitude {
            get {
                return this.longitudeField;
            }
            set {
                if ((this.longitudeField.Equals(value) != true)) {
                    this.longitudeField = value;
                    this.RaisePropertyChanged("longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string state {
            get {
                return this.stateField;
            }
            set {
                if ((object.ReferenceEquals(this.stateField, value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string street {
            get {
                return this.streetField;
            }
            set {
                if ((object.ReferenceEquals(this.streetField, value) != true)) {
                    this.streetField = value;
                    this.RaisePropertyChanged("street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string zip {
            get {
                return this.zipField;
            }
            set {
                if ((object.ReferenceEquals(this.zipField, value) != true)) {
                    this.zipField = value;
                    this.RaisePropertyChanged("zip");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Datum", Namespace="http://schemas.datacontract.org/2004/07/wcfCheckinPlaces")]
    [System.SerializableAttribute()]
    public partial class Datum : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private test.ServiceReference1.CategoryList[] category_listField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private test.ServiceReference1.Location locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public test.ServiceReference1.CategoryList[] category_list {
            get {
                return this.category_listField;
            }
            set {
                if ((object.ReferenceEquals(this.category_listField, value) != true)) {
                    this.category_listField = value;
                    this.RaisePropertyChanged("category_list");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public test.ServiceReference1.Location location {
            get {
                return this.locationField;
            }
            set {
                if ((object.ReferenceEquals(this.locationField, value) != true)) {
                    this.locationField = value;
                    this.RaisePropertyChanged("location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryList", Namespace="http://schemas.datacontract.org/2004/07/wcfCheckinPlaces")]
    [System.SerializableAttribute()]
    public partial class CategoryList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCoffeeFacebook", ReplyAction="http://tempuri.org/IService1/getCoffeeFacebookResponse")]
        string getCoffeeFacebook(string access_token, string latitude, string longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCoffeeFacebook", ReplyAction="http://tempuri.org/IService1/getCoffeeFacebookResponse")]
        System.Threading.Tasks.Task<string> getCoffeeFacebookAsync(string access_token, string latitude, string longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createLocation", ReplyAction="http://tempuri.org/IService1/createLocationResponse")]
        void createLocation(test.ServiceReference1.Location location, test.ServiceReference1.Datum datum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createLocation", ReplyAction="http://tempuri.org/IService1/createLocationResponse")]
        System.Threading.Tasks.Task createLocationAsync(test.ServiceReference1.Location location, test.ServiceReference1.Datum datum);
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
        
        public string getCoffeeFacebook(string access_token, string latitude, string longitude) {
            return base.Channel.getCoffeeFacebook(access_token, latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<string> getCoffeeFacebookAsync(string access_token, string latitude, string longitude) {
            return base.Channel.getCoffeeFacebookAsync(access_token, latitude, longitude);
        }
        
        public void createLocation(test.ServiceReference1.Location location, test.ServiceReference1.Datum datum) {
            base.Channel.createLocation(location, datum);
        }
        
        public System.Threading.Tasks.Task createLocationAsync(test.ServiceReference1.Location location, test.ServiceReference1.Datum datum) {
            return base.Channel.createLocationAsync(location, datum);
        }
    }
}
