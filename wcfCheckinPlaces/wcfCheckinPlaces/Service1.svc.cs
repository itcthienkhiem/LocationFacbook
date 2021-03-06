﻿using System;
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
        public string getImagesFromID(string fbid)
        {
            WebClient wc = new WebClient();
            string u2 = @"https://graph.facebook.com/" + fbid + "/picture?type=square";
            string access = wc.DownloadString(u2);
            return access;

        }
        public string getDataFacebook(string access_token, string latitude, string longitude, string type)
        {
            WebClient wc = new WebClient();
            string u2 = @"https://graph.facebook.com/search?q=" + type + "&type=place&center=" + latitude + "," + longitude + "&topic_filter=all&access_token=" + access_token;
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

            return fb.AccessToken;

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
        public void createLocation(Location location, Datum datum)
        {

            neo4jNodeManagement manager = new neo4jNodeManagement();
            // insert node ...
            manager.createLocation(location, datum);
        }

        public void getObject(RootObject root)
        {

        }


        public void deleteLocation(string fid)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.deleteLocation(fid);
        }

        public void deleteLocation()
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.deleteLocation();

        }

        public void createCategoryList(CategoryList C)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.createCategoryList(C);

        }

        public void deleteCategoryList(string id)
        {
            //lam giong nhung phan o tren -> goi lai ham trong manager , bo dong throw di 
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.deleteCategoryList(id);
            // throw new NotImplementedException();
        }

        public void createDatum(Datum D)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.createDatum(D);
            //throw new NotImplementedException();
        }

        public void deleteDatum(string id)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.deleteDatum(id);
            //throw new NotImplementedException();
        }

        public void createRelationLocationCategoryList(string location_fid, string categorylist_id)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.createRelationLocationCategoryList(location_fid, categorylist_id);
            //throw new NotImplementedException();
        }

        public void createRelationCategoryListLocation(string categorylist_id, string location_fid)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.createRelationCategoryListLocation(categorylist_id, location_fid);
            //throw new NotImplementedException();
        }

        public void createRelationDatumCategoryList(string Did, string Cid)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.createRelationDatumCategoryList(Did, Cid);
            //throw new NotImplementedException();
        }

        public void createRelationDatumCategoryList()
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.createRelationDatumCategoryList();
            //throw new NotImplementedException();
        }

        public void createRelationDatumLocation()
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.createRelationDatumLocation();
            //throw new NotImplementedException();
        }

        public void addPropertyNode(string name_object, string fid, Dictionary<string, int> dict)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.addPropertyNode(name_object, fid, dict);
            //throw new NotImplementedException();
        }

        public void removePropertyNode(string name_object, string fid, List<string> parameters)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
            manager.removePropertyNode(name_object, fid, parameters);
            //throw new NotImplementedException();
        }

        //public void selectLocationHaveTheSameCategoryList(string name)
        //{
        //    neo4jNodeManagement manager = new neo4jNodeManagement();
        //    manager.selectLocationHaveTheSameCategoryList(name);
        //}
        public List<Location> selectLocationHaveTheSameCategoryList(string nameOfCategoryList)
        {
            neo4jNodeManagement manager = new neo4jNodeManagement();
           return  manager.selectLocationHaveTheSameCategoryList(nameOfCategoryList);
        }
        
    }
    
}
