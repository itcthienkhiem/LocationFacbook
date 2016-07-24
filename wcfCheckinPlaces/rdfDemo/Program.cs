using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDFSharp.Model;

namespace rdfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            rdfDemo.ServiceReference1.Location[] lstResult = client.selectLocationHaveTheSameCategoryList("Cafe");
            
//
//CREATE RESOURCE FROM STRING
RDFResource donaldduck   = new RDFResource("http://www.waltdisney.com/donald_duck"); 
// CREATE RESOURCE FROM URI 
RDFResource goofygoof    = new RDFResource(new Uri("http://www.waltdisney.com/goofy_goof")); 
// CREATE BLANK RESOURCE 
RDFResource disney_group = new RDFResource();
            //
//CREATE PLAIN LITERAL
// "Donald Duck" 
RDFPlainLiteral donaldduck_name       = new RDFPlainLiteral("Donald Duck"); 
// CREATE PLAIN LITERAL WITH LANGUAGE TAG 
// "Donald Duck"@en-US 
RDFPlainLiteral donaldduck_name_enus  = new RDFPlainLiteral("Donald Duck", "en-US"); 
// CREATE TYPED LITERAL 
// "85"^^xsd:integer 
List<RDFTriple> triples = new List<RDFTriple>();
            foreach (var item in lstResult)
{

                RDFTypedLiteral name = new RDFTypedLiteral(item.name, RDFDatatypeRegister.
                GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple name_r
                      = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/NAME"),
                            name);
                triples.Add(name_r);

                //add L.latitude
                RDFTypedLiteral lat = new RDFTypedLiteral(item.latitude.ToString(), RDFDatatypeRegister.
                GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple lat_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            lat);
                triples.Add(lat_r);

                //add L.fid
                RDFTypedLiteral fid = new RDFTypedLiteral(item.fid.ToString(), RDFDatatypeRegister.
                    GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple fid_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            fid);
                triples.Add(fid_r);

                //add L.city
                RDFTypedLiteral city = new RDFTypedLiteral(item.city.ToString(), RDFDatatypeRegister.
                        GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple city_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            city);
                triples.Add(city_r);

                //add L.country
                RDFTypedLiteral country = new RDFTypedLiteral(item.country.ToString(), RDFDatatypeRegister.
                        GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple country_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            country);
                triples.Add(country_r);

                //add L.longitude
                RDFTypedLiteral longitude = new RDFTypedLiteral(item.longitude.ToString(), RDFDatatypeRegister.
                        GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple longitude_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            longitude);
                triples.Add(longitude_r);

                //add L.state
                RDFTypedLiteral state = new RDFTypedLiteral(item.state.ToString(), RDFDatatypeRegister.
                        GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple state_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            state);
                triples.Add(state_r);

                //add L.street
                RDFTypedLiteral street = new RDFTypedLiteral(item.street.ToString(), RDFDatatypeRegister.
                        GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple street_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            street);
                triples.Add(street_r);

                //add L.zip
                RDFTypedLiteral zip = new RDFTypedLiteral(item.zip.ToString(), RDFDatatypeRegister.
                        GetByPrefixAndDatatype("xsd", "string"));
                RDFTriple zip_r
                        = new RDFTriple(
                            new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                            new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                            zip);
                triples.Add(zip_r);

            }
RDFGraph waltdisney_filled = new RDFGraph(triples);
            // 
//SET CONTEXT OF A 
//GRAPH
// GET A GRAPH FROM A DATATABLE 
RDFGraphSerializer.WriteRDF(
RDFModelEnums.RDFFormats.RdfXml, waltdisney_filled, "D:\\newfile.rdf"); 
        }
    }
}
