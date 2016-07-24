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
//add them thuoc tinh cho nay 
    RDFTypedLiteral lat = new RDFTypedLiteral(item.latitude.ToString(), RDFDatatypeRegister.
    GetByPrefixAndDatatype("xsd", "string"));
    RDFTriple lat_r
          = new RDFTriple(
                new RDFResource("http://www.waltdisney.com/mickey_mouse"),
                new RDFResource("http://xmlns.com/foaf/0.1/lat"),
                lat);
    triples.Add(lat_r);

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
