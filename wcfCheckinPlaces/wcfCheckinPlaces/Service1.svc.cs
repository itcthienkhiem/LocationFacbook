using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Facebook;

namespace wcfCheckinPlaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public object getPositionWebUser(string FacebookAccessToken)
        {
            var facebookClient = new FacebookClient(FacebookAccessToken);
            var me = facebookClient.Get("me") as JsonObject;
            var uid = me["id"];
            return uid;
        }
        
        public string getBarFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "bar");
        }
        public string getShoppingFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "Shopping");
        }
        public string getCoffeeFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "coffee");
        }

        public string getFunFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "fun");
        }
        public string getRestaurentFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "restaurent");
        }
        public string getArtsFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "arts");
        }
        public string getNightlifeFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "Nightlife");
        }
        public string getFoodyFacebook(string access_token, string latitude, string longitude)
        {
            return getDataFacebook(access_token, latitude, longitude, "food");        
        }
        public string getImagesFromID( string fbid )
        {
            WebClient wc = new WebClient();
            string u2 = @"https://graph.facebook.com/"+fbid+"/picture?type=square";
            string access = wc.DownloadString(u2);
            return access;
            
        }
        public string getDataFacebook(string access_token, string latitude, string longitude,string type)
        {
            WebClient wc = new WebClient();
            string u2 = @"https://graph.facebook.com/search?q="+type +"&type=place&center="+latitude +","+longitude+"&topic_filter=all&access_token="+access_token;
            string access = wc.DownloadString(u2);
            return access;
        }
        /// <summary>
        /// hàm lấy danh sách 
        /// </summary>
        /// <param name="AppID"></param>
        /// <param name="AppSecret"></param>
        /// <returns></returns>
        public string getAllAlbumsImages(string AppID, string AppSecret)
        {

            Dictionary<string, object> searchParams = new Dictionary<string, object>();
            searchParams.Add("q", "coffee");
            searchParams.Add("center", "37.76,-122.427");
            searchParams.Add("type", "place");
            searchParams.Add("distance", "1000");

            FacebookClient fbClient = new FacebookClient("1387174581298632|VF96nLPKg9EOglF3nSjamJCAFXU");
            var searchedPlaces = fbClient.Get("albums", searchParams); 

            return "";
        }
        /// <summary>
        /// hàm lấy danh sách tất cả các photo images của fb
        /// </summary>
        /// <param name="access_token"></param>
        /// <param name="albumID"></param>
        /// <returns></returns>
        public string getAllPhotoImages(string access_token, string albumID)
        {

            Dictionary<string, object> searchParams = new Dictionary<string, object>();
            searchParams.Add("fields", "album,from,height,images,link,id,name");


            FacebookClient fbClient = new FacebookClient(access_token);
            var searchedPlaces = fbClient.Get(albumID, searchParams);

            return searchedPlaces.ToString();
        }
        /// <summary>
        /// hàm lấy danh sách các albums id của fb
        /// </summary>
        /// <param name="access_token"></param>
        /// <param name="locationID">id địa điểm</param>
        /// <returns></returns>
        public string getAllAlbums(string access_token, string locationID)
        {

         //   Dictionary<string, object> searchParams = new Dictionary<string, object>();
         //   searchParams.Add("albums", "album,from,height,images,link,id,name");


            FacebookClient fbClient = new FacebookClient(access_token);
            var searchedPlaces = fbClient.Get(locationID + "/" + "albums");

            return searchedPlaces.ToString();
        }
        public string GetAccessTokenFromCode(string AppID, string AppSecret)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Get("oauth/access_token", new
            {
                client_id = AppID,
                client_secret = AppSecret,
                grant_type = "client_credentials"
            });
            fb.AccessToken = result.access_token;

            return fb.AccessToken ;
            
            //WebClient wc = new WebClient();
            //string u2 = @"https://graph.facebook.com/search?q=coffee&type=place&center=37.76,122.427&topic_filter=all&access_token=EAATtoMAo5cgBAO1tGfjQZCppIqvREU7KZCwneqxAurhESHR0rcM3nm8d5CA7ANhU2Hj65SYu9xvTrAMZAtV530pe0Q0ZARZBld78xO5UZCDMbMf4tQVIftfeFuGAP5n3du5UEtxqOBy9626pU4LIKNyUP5Xxa7DiWmbenle0mkhAZDZD";
            //string access = wc.DownloadString(u2);
            
            //return access;

        }


        public string getFoodFacebook(string access_token, string latitude, string longitude)
        {
            throw new NotImplementedException();
        }
        // neo4j 
        public int insertNote()
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            // insert node ...
        }


    }
}
