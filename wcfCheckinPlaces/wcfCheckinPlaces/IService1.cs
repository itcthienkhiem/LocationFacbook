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
        CompositeType GetDataUsingDataContract(CompositeType composite);

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


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
