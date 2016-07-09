
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



public class neo4jNodeManagement
{
    //anh viet them ham createLocation voi tham so input la class location  em vd nha 
    /// <summary>
    /// truoc khi create anh kiem tra node da ton tai chua anh viet them ham check ton tai note
    /// cai fid cua location nam trong datum nen anh phai triuyen datum vao nua de check 
    /// </summary>
    /// <param name="location"></param>
    ///
    public void createLocation(Location location,Datum datum)
    {
        //kiem trra xem id cua location co ton tai trong neo4j chua 
        // = 0: chua co thi insert moi vao 
        //=1 : da co thi insert vao 
//        if (checkExitsLocation(datum.id) == 0)
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
            using (var session = driver.Session())
            {
                string command = String.Format("MERGE(L: Location { street: '{0}',city: '{1}',state: '{2}',country: '{3}',zip: '{4}',latitude: { 5},longitude: { 6},fid: '{7}',name: '{8}'})", location.street, location.city, location.state, location.country, location.zip, location.latitude, location.longitude,datum.id,datum.name);
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
    public void deleteLocation(string fid) { }
    public void deleteLocation()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (L:Location) WHERE L.latitude=37.759981550117 AND L.longitude=-122.42685274675 DETACH DELETE L");
        }
    }
    //create a catalogylist
    //them ham createCategogyList(CatelogyList)
    public void createCategoryList()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MERGE (CL:CategoryList {id:'128673187201735',name:'Coffee Shop'})");
        }
    }
    //delete a categoryList and Its all relationship
    //them ham deleteCatelogyList(string id)
    public void deleteCategoryList()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (CL:CategoryList) WHERE CL.id='115090141929327' DETACH DELETE CL");
        }
    }
    ////create a datum
    //public void createDatum()
    //{
    //    using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
    //    using (var session = driver.Session())
    //    {
    //        session.Run("MERGE (D:Datum {category:'Local business',name:'Samovar Tea & Chai Valencia',id:'198089667210156'})");
    //    }
    //}
    //delete a datum
    public void deleteDatum()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (D:Datum) WHERE D.id='461496983865298' DETACH DELETE D");
        }
    }
    //create relationship between Datum and Location
    //them ham tao relation giua category list va location 
    //createRelationCategogyList(string fid_category,string fid_location)
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
                command += "D." + item.Key + " = " + item.Value+",";
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
    //anh them ham remote propertiser note void tham so dauu vao name_object,fid, dictionnary...
    public void removePropertyNode(string name_object,string fid,List<string> parameters)

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
    // anh them ham update gia tru parameter cua note vd 
    public void updateParameter( string street_old, string street_new)
    {
        //cap nhat gia tri street trong location street cu thanh moi 
    } 
}

