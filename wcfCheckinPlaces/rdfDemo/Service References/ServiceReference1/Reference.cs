﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rdfDemo.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
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
        private rdfDemo.ServiceReference1.CategoryList[] category_listField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private rdfDemo.ServiceReference1.Location locationField;
        
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
        public rdfDemo.ServiceReference1.CategoryList[] category_list {
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
        public rdfDemo.ServiceReference1.Location location {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RootObject", Namespace="http://schemas.datacontract.org/2004/07/wcfCheckinPlaces")]
    [System.SerializableAttribute()]
    public partial class RootObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private rdfDemo.ServiceReference1.Datum[] dataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private rdfDemo.ServiceReference1.Paging pagingField;
        
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
        public rdfDemo.ServiceReference1.Datum[] data {
            get {
                return this.dataField;
            }
            set {
                if ((object.ReferenceEquals(this.dataField, value) != true)) {
                    this.dataField = value;
                    this.RaisePropertyChanged("data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public rdfDemo.ServiceReference1.Paging paging {
            get {
                return this.pagingField;
            }
            set {
                if ((object.ReferenceEquals(this.pagingField, value) != true)) {
                    this.pagingField = value;
                    this.RaisePropertyChanged("paging");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Paging", Namespace="http://schemas.datacontract.org/2004/07/wcfCheckinPlaces")]
    [System.SerializableAttribute()]
    public partial class Paging : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nextField;
        
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
        public string next {
            get {
                return this.nextField;
            }
            set {
                if ((object.ReferenceEquals(this.nextField, value) != true)) {
                    this.nextField = value;
                    this.RaisePropertyChanged("next");
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
        void createLocation(rdfDemo.ServiceReference1.Location location, rdfDemo.ServiceReference1.Datum datum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createLocation", ReplyAction="http://tempuri.org/IService1/createLocationResponse")]
        System.Threading.Tasks.Task createLocationAsync(rdfDemo.ServiceReference1.Location location, rdfDemo.ServiceReference1.Datum datum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getObject", ReplyAction="http://tempuri.org/IService1/getObjectResponse")]
        void getObject(rdfDemo.ServiceReference1.RootObject root);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getObject", ReplyAction="http://tempuri.org/IService1/getObjectResponse")]
        System.Threading.Tasks.Task getObjectAsync(rdfDemo.ServiceReference1.RootObject root);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteLocation", ReplyAction="http://tempuri.org/IService1/deleteLocationResponse")]
        void deleteLocation(string fid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteLocation", ReplyAction="http://tempuri.org/IService1/deleteLocationResponse")]
        System.Threading.Tasks.Task deleteLocationAsync(string fid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createCategoryList", ReplyAction="http://tempuri.org/IService1/createCategoryListResponse")]
        void createCategoryList(rdfDemo.ServiceReference1.CategoryList C);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createCategoryList", ReplyAction="http://tempuri.org/IService1/createCategoryListResponse")]
        System.Threading.Tasks.Task createCategoryListAsync(rdfDemo.ServiceReference1.CategoryList C);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteCategoryList", ReplyAction="http://tempuri.org/IService1/deleteCategoryListResponse")]
        void deleteCategoryList(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteCategoryList", ReplyAction="http://tempuri.org/IService1/deleteCategoryListResponse")]
        System.Threading.Tasks.Task deleteCategoryListAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createDatum", ReplyAction="http://tempuri.org/IService1/createDatumResponse")]
        void createDatum(rdfDemo.ServiceReference1.Datum D);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createDatum", ReplyAction="http://tempuri.org/IService1/createDatumResponse")]
        System.Threading.Tasks.Task createDatumAsync(rdfDemo.ServiceReference1.Datum D);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteDatum", ReplyAction="http://tempuri.org/IService1/deleteDatumResponse")]
        void deleteDatum(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteDatum", ReplyAction="http://tempuri.org/IService1/deleteDatumResponse")]
        System.Threading.Tasks.Task deleteDatumAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationLocationCategoryList", ReplyAction="http://tempuri.org/IService1/createRelationLocationCategoryListResponse")]
        void createRelationLocationCategoryList(string location_fid, string categorylist_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationLocationCategoryList", ReplyAction="http://tempuri.org/IService1/createRelationLocationCategoryListResponse")]
        System.Threading.Tasks.Task createRelationLocationCategoryListAsync(string location_fid, string categorylist_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationCategoryListLocation", ReplyAction="http://tempuri.org/IService1/createRelationCategoryListLocationResponse")]
        void createRelationCategoryListLocation(string categorylist_id, string location_fid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationCategoryListLocation", ReplyAction="http://tempuri.org/IService1/createRelationCategoryListLocationResponse")]
        System.Threading.Tasks.Task createRelationCategoryListLocationAsync(string categorylist_id, string location_fid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationDatumCategoryList", ReplyAction="http://tempuri.org/IService1/createRelationDatumCategoryListResponse")]
        void createRelationDatumCategoryList(string Did, string Cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationDatumCategoryList", ReplyAction="http://tempuri.org/IService1/createRelationDatumCategoryListResponse")]
        System.Threading.Tasks.Task createRelationDatumCategoryListAsync(string Did, string Cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationDatumLocation", ReplyAction="http://tempuri.org/IService1/createRelationDatumLocationResponse")]
        void createRelationDatumLocation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createRelationDatumLocation", ReplyAction="http://tempuri.org/IService1/createRelationDatumLocationResponse")]
        System.Threading.Tasks.Task createRelationDatumLocationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPropertyNode", ReplyAction="http://tempuri.org/IService1/addPropertyNodeResponse")]
        void addPropertyNode(string name_object, string fid, System.Collections.Generic.Dictionary<string, int> dict);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPropertyNode", ReplyAction="http://tempuri.org/IService1/addPropertyNodeResponse")]
        System.Threading.Tasks.Task addPropertyNodeAsync(string name_object, string fid, System.Collections.Generic.Dictionary<string, int> dict);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/removePropertyNode", ReplyAction="http://tempuri.org/IService1/removePropertyNodeResponse")]
        void removePropertyNode(string name_object, string fid, string[] parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/removePropertyNode", ReplyAction="http://tempuri.org/IService1/removePropertyNodeResponse")]
        System.Threading.Tasks.Task removePropertyNodeAsync(string name_object, string fid, string[] parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/selectLocationHaveTheSameCategoryList", ReplyAction="http://tempuri.org/IService1/selectLocationHaveTheSameCategoryListResponse")]
        rdfDemo.ServiceReference1.Location[] selectLocationHaveTheSameCategoryList(string nameOfCategoryList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/selectLocationHaveTheSameCategoryList", ReplyAction="http://tempuri.org/IService1/selectLocationHaveTheSameCategoryListResponse")]
        System.Threading.Tasks.Task<rdfDemo.ServiceReference1.Location[]> selectLocationHaveTheSameCategoryListAsync(string nameOfCategoryList);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : rdfDemo.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<rdfDemo.ServiceReference1.IService1>, rdfDemo.ServiceReference1.IService1 {
        
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
        
        public void createLocation(rdfDemo.ServiceReference1.Location location, rdfDemo.ServiceReference1.Datum datum) {
            base.Channel.createLocation(location, datum);
        }
        
        public System.Threading.Tasks.Task createLocationAsync(rdfDemo.ServiceReference1.Location location, rdfDemo.ServiceReference1.Datum datum) {
            return base.Channel.createLocationAsync(location, datum);
        }
        
        public void getObject(rdfDemo.ServiceReference1.RootObject root) {
            base.Channel.getObject(root);
        }
        
        public System.Threading.Tasks.Task getObjectAsync(rdfDemo.ServiceReference1.RootObject root) {
            return base.Channel.getObjectAsync(root);
        }
        
        public void deleteLocation(string fid) {
            base.Channel.deleteLocation(fid);
        }
        
        public System.Threading.Tasks.Task deleteLocationAsync(string fid) {
            return base.Channel.deleteLocationAsync(fid);
        }
        
        public void createCategoryList(rdfDemo.ServiceReference1.CategoryList C) {
            base.Channel.createCategoryList(C);
        }
        
        public System.Threading.Tasks.Task createCategoryListAsync(rdfDemo.ServiceReference1.CategoryList C) {
            return base.Channel.createCategoryListAsync(C);
        }
        
        public void deleteCategoryList(string id) {
            base.Channel.deleteCategoryList(id);
        }
        
        public System.Threading.Tasks.Task deleteCategoryListAsync(string id) {
            return base.Channel.deleteCategoryListAsync(id);
        }
        
        public void createDatum(rdfDemo.ServiceReference1.Datum D) {
            base.Channel.createDatum(D);
        }
        
        public System.Threading.Tasks.Task createDatumAsync(rdfDemo.ServiceReference1.Datum D) {
            return base.Channel.createDatumAsync(D);
        }
        
        public void deleteDatum(string id) {
            base.Channel.deleteDatum(id);
        }
        
        public System.Threading.Tasks.Task deleteDatumAsync(string id) {
            return base.Channel.deleteDatumAsync(id);
        }
        
        public void createRelationLocationCategoryList(string location_fid, string categorylist_id) {
            base.Channel.createRelationLocationCategoryList(location_fid, categorylist_id);
        }
        
        public System.Threading.Tasks.Task createRelationLocationCategoryListAsync(string location_fid, string categorylist_id) {
            return base.Channel.createRelationLocationCategoryListAsync(location_fid, categorylist_id);
        }
        
        public void createRelationCategoryListLocation(string categorylist_id, string location_fid) {
            base.Channel.createRelationCategoryListLocation(categorylist_id, location_fid);
        }
        
        public System.Threading.Tasks.Task createRelationCategoryListLocationAsync(string categorylist_id, string location_fid) {
            return base.Channel.createRelationCategoryListLocationAsync(categorylist_id, location_fid);
        }
        
        public void createRelationDatumCategoryList(string Did, string Cid) {
            base.Channel.createRelationDatumCategoryList(Did, Cid);
        }
        
        public System.Threading.Tasks.Task createRelationDatumCategoryListAsync(string Did, string Cid) {
            return base.Channel.createRelationDatumCategoryListAsync(Did, Cid);
        }
        
        public void createRelationDatumLocation() {
            base.Channel.createRelationDatumLocation();
        }
        
        public System.Threading.Tasks.Task createRelationDatumLocationAsync() {
            return base.Channel.createRelationDatumLocationAsync();
        }
        
        public void addPropertyNode(string name_object, string fid, System.Collections.Generic.Dictionary<string, int> dict) {
            base.Channel.addPropertyNode(name_object, fid, dict);
        }
        
        public System.Threading.Tasks.Task addPropertyNodeAsync(string name_object, string fid, System.Collections.Generic.Dictionary<string, int> dict) {
            return base.Channel.addPropertyNodeAsync(name_object, fid, dict);
        }
        
        public void removePropertyNode(string name_object, string fid, string[] parameters) {
            base.Channel.removePropertyNode(name_object, fid, parameters);
        }
        
        public System.Threading.Tasks.Task removePropertyNodeAsync(string name_object, string fid, string[] parameters) {
            return base.Channel.removePropertyNodeAsync(name_object, fid, parameters);
        }
        
        public rdfDemo.ServiceReference1.Location[] selectLocationHaveTheSameCategoryList(string nameOfCategoryList) {
            return base.Channel.selectLocationHaveTheSameCategoryList(nameOfCategoryList);
        }
        
        public System.Threading.Tasks.Task<rdfDemo.ServiceReference1.Location[]> selectLocationHaveTheSameCategoryListAsync(string nameOfCategoryList) {
            return base.Channel.selectLocationHaveTheSameCategoryListAsync(nameOfCategoryList);
        }
    }
}
