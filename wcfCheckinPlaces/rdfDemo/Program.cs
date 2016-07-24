using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RDFSharp.Model;
using RDFSharp.Query;
using VDS.RDF;
using VDS.RDF.Query;
using VDS.RDF.Writing;

namespace rdfDemo
{
    class Program
    {
        public static void readRDF()
        {
            //Define your Graph here - it may be better to use a QueryableGraph if you plan
            //on making lots of Queries against this Graph as that is marginally more performant
            IGraph g = new Graph();

            //Load some data into your Graph using the LoadFromFile() extension method
            g.LoadFromFile("HelloWorld.rdf");

            //Use the extension method ExecuteQuery() to make the query against the Graph
            try
            {
                Object results = g.ExecuteQuery("SELECT * WHERE { ?name ?fid ?street }");
                if (results is SparqlResultSet)
                {
                    //SELECT/ASK queries give a SparqlResultSet
                    SparqlResultSet rset = (SparqlResultSet)results;
                    foreach (SparqlResult r in rset)
                    {
                        Console.WriteLine(r);
                        //Do whatever you want with each Result
                    }
                }
                else if (results is IGraph)
                {
                    //CONSTRUCT/DESCRIBE queries give a IGraph
                    IGraph resGraph = (IGraph)results;
                    foreach (Triple t in resGraph.Triples)
                    {
                        //Do whatever you want with each Triple
                    }
                }
                else
                {
                    //If you don't get a SparqlResutlSet or IGraph something went wrong 
                    //but didn't throw an exception so you should handle it here
                    Console.WriteLine("ERROR");
                }
            }
            catch (RdfQueryException queryEx)
            {
                //There was an error executing the query so handle it here
                Console.WriteLine(queryEx.Message);
            }
        }
        static void Main(string[] args)
        {

            readRDF();
            return;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            rdfDemo.ServiceReference1.Location[] lstResult = client.selectLocationHaveTheSameCategoryList("Cafe");
            //Fill in the code shown on this page here to build your hello world application
            Graph g = new Graph();

            IUriNode dotNetRDF = g.CreateUriNode(UriFactory.Create("http://www.dotnetrdf.org"));
            IUriNode says = g.CreateUriNode(UriFactory.Create("http://example.org/location"));
            foreach (var item in lstResult)
            {
                ILiteralNode fid = g.CreateLiteralNode(item.fid);
                ILiteralNode name = g.CreateLiteralNode(item.name);
                ILiteralNode city = g.CreateLiteralNode(item.city);
                ILiteralNode country = g.CreateLiteralNode(item.country);
                ILiteralNode latitude = g.CreateLiteralNode(item.latitude.ToString());
                ILiteralNode longitude = g.CreateLiteralNode(item.longitude.ToString());
                ILiteralNode state = g.CreateLiteralNode(item.state);
                ILiteralNode street = g.CreateLiteralNode(item.street);
                ILiteralNode zip = g.CreateLiteralNode(item.zip);

                g.Assert(new Triple(dotNetRDF, says, fid));
                g.Assert(new Triple(dotNetRDF, says, name));
                g.Assert(new Triple(dotNetRDF, says, city));

                g.Assert(new Triple(dotNetRDF, says, country));
                g.Assert(new Triple(dotNetRDF, says, latitude));
                g.Assert(new Triple(dotNetRDF, says, longitude));

                g.Assert(new Triple(dotNetRDF, says, state));
                g.Assert(new Triple(dotNetRDF, says, street));
                g.Assert(new Triple(dotNetRDF, says, zip));

                
                foreach (Triple t in g.Triples)
                {
                    Console.WriteLine(t.ToString());
                }

            }

            NTriplesWriter ntwriter = new NTriplesWriter();
            ntwriter.Save(g, "HelloWorld.nt");

            RdfXmlWriter rdfxmlwriter = new RdfXmlWriter();
            rdfxmlwriter.Save(g, "HelloWorld.rdf");

            Console.ReadLine();
////
////CREATE RESOURCE FROM STRING
//RDFResource donaldduck   = new RDFResource("http://www.waltdisney.com/donald_duck"); 
//// CREATE RESOURCE FROM URI 
//RDFResource goofygoof    = new RDFResource(new Uri("http://www.waltdisney.com/goofy_goof")); 
//// CREATE BLANK RESOURCE 
//RDFResource disney_group = new RDFResource();
//            //
////CREATE PLAIN LITERAL
//// "Donald Duck" 
//RDFPlainLiteral donaldduck_name       = new RDFPlainLiteral("Donald Duck"); 
//// CREATE PLAIN LITERAL WITH LANGUAGE TAG 
//// "Donald Duck"@en-US 
//RDFPlainLiteral donaldduck_name_enus  = new RDFPlainLiteral("Donald Duck", "en-US"); 
//// CREATE TYPED LITERAL 
//// "85"^^xsd:integer 
//List<RDFTriple> triples = new List<RDFTriple>();
//            foreach (var item in lstResult)
//{

//                RDFTypedLiteral name = new RDFTypedLiteral(item.name, RDFDatatypeRegister.
//                GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple name_r
//                      = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/NAME"),
//                            name);
//                triples.Add(name_r);

//                //add L.latitude
//                RDFTypedLiteral lat = new RDFTypedLiteral(item.latitude.ToString(), RDFDatatypeRegister.
//                GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple lat_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            lat);
//                triples.Add(lat_r);

//                //add L.fid
//                RDFTypedLiteral fid = new RDFTypedLiteral(item.fid.ToString(), RDFDatatypeRegister.
//                    GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple fid_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            fid);
//                triples.Add(fid_r);

//                //add L.city
//                RDFTypedLiteral city = new RDFTypedLiteral(item.city.ToString(), RDFDatatypeRegister.
//                        GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple city_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            city);
//                triples.Add(city_r);

//                //add L.country
//                RDFTypedLiteral country = new RDFTypedLiteral(item.country.ToString(), RDFDatatypeRegister.
//                        GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple country_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            country);
//                triples.Add(country_r);

//                //add L.longitude
//                RDFTypedLiteral longitude = new RDFTypedLiteral(item.longitude.ToString(), RDFDatatypeRegister.
//                        GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple longitude_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            longitude);
//                triples.Add(longitude_r);

//                //add L.state
//                RDFTypedLiteral state = new RDFTypedLiteral(item.state.ToString(), RDFDatatypeRegister.
//                        GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple state_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            state);
//                triples.Add(state_r);

//                //add L.street
//                RDFTypedLiteral street = new RDFTypedLiteral(item.street.ToString(), RDFDatatypeRegister.
//                        GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple street_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            street);
//                triples.Add(street_r);

//                //add L.zip
//                RDFTypedLiteral zip = new RDFTypedLiteral(item.zip.ToString(), RDFDatatypeRegister.
//                        GetByPrefixAndDatatype("xsd", "string"));
//                RDFTriple zip_r
//                        = new RDFTriple(
//                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
//                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
//                            zip);
//                triples.Add(zip_r);

//            }
//RDFGraph waltdisney_filled = new RDFGraph(triples);
//            // 
////SET CONTEXT OF A 
////GRAPH
//// GET A GRAPH FROM A DATATABLE 
//RDFGraphSerializer.WriteRDF(
//RDFModelEnums.RDFFormats.RdfXml, waltdisney_filled, "D:\\newfile.rdf"); 
        }
    }
}
