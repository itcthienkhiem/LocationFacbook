using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfCheckinPlaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string GetAccessTokenFromCode(string AppID, string AppSecret);
        [OperationContract]
        string getFoodFacebook(string access_token, string latitude, string longitude);
        // TODO: Add your service operations here
        [OperationContract]
        string getAllAlbumsImages(string AppID, string AppSecret);
        [OperationContract]
        string getAllPhotoImages(string access_token, string albumID);
        [OperationContract]
        string getAllAlbums(string access_token, string locationID);
       
        [OperationContract]
        string getCoffeeFacebook(string access_token, string latitude, string longitude);
        [OperationContract]
        void createLocation(Location location, Datum datum);
        [OperationContract]
        void getObject(RootObject root);
        [OperationContract]
        void deleteLocation(string fid);
        
        [OperationContract]
        void createCategoryList(CategoryList C);
        [OperationContract]
        void deleteCategoryList(String id);
        [OperationContract]
        void createDatum(Datum D);
        [OperationContract]
        void deleteDatum(string id);
        [OperationContract]
        void createRelationLocationCategoryList(string location_fid, string categorylist_id);
        [OperationContract]
        void createRelationCategoryListLocation(string categorylist_id, string location_fid);
        [OperationContract]
        void createRelationDatumCategoryList(string Did, string Cid);
      
        [OperationContract]
        void createRelationDatumLocation();
        [OperationContract]
        void addPropertyNode(string name_object, string fid, Dictionary<string, int> dict);
        [OperationContract]
        void removePropertyNode(string name_object, string fid, List<string> parameters);

    }


    [DataContract]
    public class CategoryList
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }
    }
    [DataContract]
    public class Location
    {
        [DataMember]
        public string street { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string state { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string zip { get; set; }
        [DataMember]
        public double latitude { get; set; }
        [DataMember]
        public double longitude { get; set; }
        [DataMember]
        public string fid { get; set; }
        [DataMember]
        public string name { get; set; }
    }
    [DataContract]
    public class Datum
    {
        [DataMember]
        public string category { get; set; }
        [DataMember]
        public List<CategoryList> category_list { get; set; }
        [DataMember]
        public Location location { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string id { get; set; }
    }
    [DataContract]
    public class Paging
    {
        [DataMember]
        public string next { get; set; }
    }
    [DataContract]
    public class RootObject
    {
        [DataMember]
        public List<Datum> data { get; set; }
        [DataMember]
        public Paging paging { get; set; }
    }
}
