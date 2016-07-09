
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
    public void deleteLocation()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (L:Location) WHERE L.latitude=37.759981550117 AND L.longitude=-122.42685274675 DETACH DELETE L");
        }
    }
    //create a catalogylist
    public void createCategoryList()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MERGE (CL:CategoryList {id:'128673187201735',name:'Coffee Shop'})");
        }
    }
    //delete a categoryList and Its all relationship
    public void deleteCategoryList()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MATCH (CL:CategoryList) WHERE CL.id='115090141929327' DETACH DELETE CL");
        }
    }
    //create a datum
    public void createDatum()
    {
        using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "123456")))
        using (var session = driver.Session())
        {
            session.Run("MERGE (D:Datum {category:'Local business',name:'Samovar Tea & Chai Valencia',id:'198089667210156'})");
        }
    }
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
}

