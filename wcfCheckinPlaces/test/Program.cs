﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ServiceReference1.Service1Client c = new ServiceReference1.Service1Client();
            //c.getAllPhotoImages("1387174581298632", "336174fabd97c0d9fa43a75d43956e84");
            //  c.getAllAlbums("1387174581298632|VF96nLPKg9EOglF3nSjamJCAFXU", "225005490914488");
            // access_token is first get for all working...
            string access_token =  c.GetAccessTokenFromCode("1387174581298632", "336174fabd97c0d9fa43a75d43956e84");
            var objects = c.getCoffeeFacebook(access_token, "10.823099", "106.629664");
            ServiceReference1.RootObject result = JsonConvert.DeserializeObject<ServiceReference1.RootObject>(objects.ToString());
            foreach (var item in result.data)
            {
                c.createLocationAsync( item.location, item);//insert location

                //insert catagory
                for(int i=0;i<item.category_list.Length;i++)
                {
                    c.createCategoryList(item.category_list[i]);
                }
                
                //insert location
                
                
                //insert quan he
                for(int j=0;j<item.category_list.Length;j++)
                {
                    c.createRelationCategoryListLocation(item.category_list[j].id, item.location.fid);
                }
            }
            //convert json to class 
            //insert class to neo4j from webservices 


        }
    }
}
