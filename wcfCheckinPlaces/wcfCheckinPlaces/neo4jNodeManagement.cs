using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver.V1;

public class CategoryList
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Location
{
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string zip { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string fid { get; set; }
    public string name { get; set; }
}

public class Datum
{
    public string category { get; set; }
    public List<CategoryList> category_list { get; set; }
    public Location location { get; set; }
    public string name { get; set; }
    public string id { get; set; }
}

public class Paging
{
    public string next { get; set; }
}

public class RootObject
{
    public List<Datum> data { get; set; }
    public Paging paging { get; set; }
}

#region aDatum
/*		
{
         "category": "Local business",
         "category_list": [
            {
               "id": "200863816597800",
               "name": "Ice Cream Parlor"
            },
            {
               "id": "187153754656815",
               "name": "Dessert Place"
            },
            {
               "id": "187827497907070",
               "name": "Bakery"
            }
         ],
         "location": {
            "street": "3692 18th St",
            "city": "San Francisco",
            "state": "CA",
            "country": "United States",
            "zip": "94110",
            "latitude": 37.7615877,
            "longitude": -122.4257548
         },
         "name": "Bi-Rite Creamery",
         "id": "230024712481"
      } */
#endregion
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            neo4jNodeManagement node = new neo4jNodeManagement();
            Location L = new Location();
            L.street = "3692 18th St";
            L.city = "San Francisco";
            L.state = "CA";
            L.country = "United States";
            L.zip = "94110";
            L.latitude = 37.7615877;
            L.longitude = -122.4257548;
            L.fid = Guid.NewGuid().ToString();
            L.name = "Sinh to kem dau";

            Datum D = new Datum();
            D.category = "Local business";
            D.id = "230024712481";
            D.name = "Bi-Rite Creamery";

            CategoryList C1 = new CategoryList();
            C1.id = "200863816597800";
            C1.name = "Ice Cream Parlor";

            CategoryList C2 = new CategoryList();
            C2.id = "187153754656815";
            C2.name = "Dessert Place";

            CategoryList C3 = new CategoryList();
            C3.id = "187827497907070";
            C3.name = "Bakery";



            // node.createLocation(L, D);
            //node.deleteLocation("fid");

            // node.createCategoryList(C1);
            // node.createCategoryList(C2);
            //node.createCategoryList(C3);
            //node.deleteCategoryList("128673187201735");

            //node.createDatum(D);
            //node.deleteDatum("230024712481");

            // node.createRelationLocationCategoryList("230024712481", "200863816597800");
            //node.createRelationLocationCategoryList("230024712481", "187153754656815");
            //node.createRelationLocationCategoryList("230024712481", "187827497907070");
            //node.createRelationDatumCategoryList();

            //node.createRelationCategoryListLocation("200863816597800", "230024712481");
            //node.createRelationCategoryListLocation("187153754656815", "230024712481");
            //node.createRelationCategoryListLocation("187827497907070", "230024712481");

            //node.createRelationDatumLocation();

            //node.createRelationDatumCategoryList("230024712481", "200863816597800");
            //node.createRelationDatumCategoryList("230024712481", "187153754656815");
            //node.createRelationDatumCategoryList("230024712481", "187827497907070");



            // node.addPropertyNode();
            //node.removePropertyNode();

        }
    }
}





public class neo4jNodeManagement
{
    //anh viet them ham createLocation voi tham so input la class location  em vd nha 
    /// <summary>
    /// truoc khi create anh kiem tra node da ton tai chua anh viet them ham check ton tai note
    /// cai fid cua location nam trong datum nen anh phai triuyen datum vao nua de check 
    /// </summary>
    /// <param name="location"></param>
    ///
    public void createLocation(Location location, Datum datum)
    {
        //kiem tra xem id cua location co ton tai trong neo4j chua 
        // = 0: chua co thi insert moi vao 
        //=1 : da co thi insert vao 
        //        if (checkExitsLocation(datum.id) == 0)
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
            using (var session = driver.Session())
            {
                string command = string.Format("MERGE(L:Location {{street:'{0}', city:'{1}', state:'{2}', country:'{3}', zip:'{4}', latitude:'{5}', longitude:'{6}', fid:'{7}', name:'{8}'}})", location.street, location.city, location.state, location.country, location.zip, location.latitude.ToString(), location.longitude.ToString(), datum.id, datum.name);

                //string tmp= "MERGE(L: Location {street: '758 Valencia St', city: 'San Francisco', state: 'CA', country: 'United States', zip: '94110', latitude: -122.42181, longitude: 0, fid: '497706443738819', name: 'Grub sf'})";
                session.Run(command);
            }
        }
    }
    //ok tiep tuc 
    //public int checkExitsLocation(string idfb)
    //{
    //    return 1;
    //}
    //create a location
    public void createLocation()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MERGE (L:Location {street:'411 Valencia St',city:'San Francisco',state:'CA',country:'United States',zip:'94103',latitude:37.766226094433,longitude:-122.42201592947})");
        }
    }
    //delete a location and Its all relationship
    //anh viet them ham deleteLocation(string fid) nhe ok
    public void deleteLocation(string fid)
    {
        Location L = new Location();
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {

            L.fid = fid;
            String command = String.Format("MATCH (L:Location{{fid:'{0}'}}) OPTIONAL MATCH (L)-[r]-() WITH L,r LIMIT 50000 DETACH DELETE L,r RETURN count(L) as deletedNodesCount", L.fid);
            session.Run(command);

        }
    }
    public void deleteLocation()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (L:Location) WHERE L.latitude=-122.4213 AND L.longitude=-122.42685274675 DETACH DELETE L");
        }
    }
    //create a catalogylist
    //them ham createCategogyList(CatelogyList)
    public void createCategoryList(CategoryList C)
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            String command = String.Format("MERGE (CL:CategoryList {{id:'{0}',name:'{1}'}})", C.id, C.name);
            session.Run(command);
        }
    }
    //delete a categoryList and Its all relationship
    //them ham deleteCatelogyList(string id)
    public void deleteCategoryList(String id)
    {
        CategoryList C = new CategoryList();
        C.id = id;
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            String command = String.Format("MATCH (CL:CategoryList {{id:'{0}'}}) OPTIONAL MATCH (CL)-[r]-() DETACH DELETE CL,r", C.id);
            session.Run(command);
        }
    }
    ////create a datum
    public void createDatum(Datum D)
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            String command = String.Format("MERGE(d: datum {{category:'{0}',name:'{1}',id:'{2}'}})", D.category, D.name, D.id);
            session.Run(command);
        }
    }
    //delete a datum
    public void deleteDatum(string id)
    {
        Datum D = new Datum();

        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            D.id = id;
            string command = string.Format("MATCH(D:Datum {{id:'{0}'}}) OPTIONAL MATCH (D)-[r]-() DETACH DELETE D,r", D.id);
            session.Run(command);
        }
    }

    //them ham tao relation giua category list va location 
    //createRelationCategogyList(string fid_category,string fid_location)
    public void createRelationLocationCategoryList(string location_fid, string categorylist_id)
    {
        Location L = new Location();
        CategoryList C = new CategoryList();
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            L.fid = location_fid;
            C.id = categorylist_id;
            string command = String.Format("MATCH (L:Location {{fid:'{0}'}}), (CL:CategoryList {{id:'{1}'}}) MERGE (L)-[r:BelongTo]->(CL)", L.fid, C.id);
            session.Run(command);
        }
    }

    public void createRelationCategoryListLocation(string categorylist_id, string location_fid)
    {
        Location L = new Location();
        CategoryList C = new CategoryList();
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            L.fid = location_fid;
            C.id = categorylist_id;
            string command = String.Format("MATCH (L:Location {{fid:'{0}'}}), (CL:CategoryList {{id:'{1}'}}) MERGE (CL)-[r:HAVE]->(L)", L.fid, C.id);
            session.Run(command);
        }
    }

    //create relationship between Datum and Location    
    public void createRelationDatumCategoryList(string Did, string Cid)
    {
        Datum D = new Datum();
        CategoryList C = new CategoryList();

        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            D.id = Did;
            C.id = Cid;
            String command = String.Format("MATCH (D:datum {{id:'{0}'}}), (CL:CategoryList {{id:'{1}'}}) MERGE (D)-[r:HAVE]->(CL)", D.id, C.id);
            session.Run(command);
        }
    }
    public void createRelationDatumCategoryList()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (D:Datum {id:'198089667210156'}), (CL:CategoryList {id:'128673187201735'}) MERGE (D)-[r:HAS]->(CL)");
        }
    }
    public void createRelationDatumLocation()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (D:Datum {id:'198089667210156'}), (L:Location {latitude:37.766226094433,longitude:-122.42201592947}) MERGE (D)-[r:BelongTo]->(L)");
        }
    }

    //Add new properties to existing Node or Relationship
    //Add or Update Properties values
    //them ham add propertyNote(string name_object,string fid,Dictionary<string, int> dict) //ham nay de em viet 

    public void addPropertyNode(string name_object, string fid, Dictionary<string, int> dict)
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            string command = string.Format("MATCH (D:{0} {id:'{1}'}) SET", name_object, fid);
            foreach (var item in dict)
            {
                command += "D." + item.Key + " = " + item.Value + ",";
            }
            command.Remove(command.Length - 1);
            command += "')";
            // SET D.Description='Description value'")
            session.Run(command);
        }
    }

    public void addPropertyNode()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (D:Datum {id:'198089667210156'}) SET D.Description='Description value' ");
        }
    }

    //To remove labels of a Node or a Relationship
    //To remove properties of a Node or a Relationship
    public void removePropertyNode()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (D:Datum {id:'198089667210156'}) REMOVE D.Description");
        }
    }
    //anh them ham remove properties node void tham so dau vao name_object,fid, dictionnary...
    public void removePropertyNode(string name_object, string fid, List<string> parameters)

    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            string command = string.Format("MATCH(D:{ 0} { id: '{1}'}) REMOVE ", name_object, fid);
            foreach (var item in parameters)
            {
                command += "D." + item + ",";
            }
            command.Remove(command.Length - 1);

            session.Run(command);// D.Description");
        }
    }
    //ok tam on :D
    // anh them ham update gia tri parameter cua node vd 
    //Cập nhật tham so cho location
    //update street
    public void updateParameter(string street_old, string street_new)
    {
        //Anh chưa hình dung là phải cập nhật tham số thế nào?
    }
}
//sau khi anh lam xong anh chon cai nay de commit code len github e chi can get ve la xong
//o tren webservices chua test dc chac phai copy xuong project cua anh de test 

