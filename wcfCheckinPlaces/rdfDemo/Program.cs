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
            rdfDemo.ServiceReference1.Location[] lstResult = client.selectLocationHaveTheSameCategoryList("cafe");
            //
            //CREATE RESOURCE FROM STRING
            RDFResource donaldduck = new RDFResource("http://www.neo4j.com/location");
            // CREATE RESOURCE FROM URI 
            RDFResource goofygoof = new RDFResource(new Uri("http://www.neo4j.com/themxua"));
            // CREATE BLANK RESOURCE 
            RDFResource disney_group = new RDFResource();
            //
            //CREATE PLAIN LITERAL
            // "Donald Duck" 
            RDFPlainLiteral donaldduck_name = new RDFPlainLiteral("Location");
            // CREATE PLAIN LITERAL WITH LANGUAGE TAG 
            // "Donald Duck"@en-US 
            RDFPlainLiteral donaldduck_name_enus = new RDFPlainLiteral("Location", "en-US");
            RDFGraph waltdisney = new RDFGraph();
            List<RDFTriple> triples = new List<RDFTriple>();
             
            foreach (var item in lstResult)
            {
                // CREATE TYPED LITERAL 
                // "85"^^xsd:integer 
                RDFTypedLiteral mickeymouse_age = new RDFTypedLiteral(item.name, RDFDatatypeRegister.
                GetByPrefixAndDatatype("xsd", item.name.GetType().ToString()));
                //  // 
                //CREATE TRIPLES
                // "Mickey Mouse is 85 years old" 
                RDFTriple mickeymouse_is85yr
                      = new RDFTriple(
                            new RDFResource("http://www.neo4j.com/location"),
                            new RDFResource("http://xmlns.com/foaf/0.1/"+item.name),
                            mickeymouse_age);
                // "Donald Duck has English-US name "Donald Duck"" 
                //RDFTriple donaldduck_name_enus = new RDFTriple( 
                //    donaldduck,             new RDFResource("http://xmlns.com/foaf/0.1/name"),             donaldduck_name_enus);
                /// CREATE EMPTY GRAPH
                // CREATE GRAPH FROM A LIST OF TRIPLES
                triples.Add(mickeymouse_is85yr);
                // 
                //SET CONTEXT OF A 
                //GRAPH
                waltdisney.SetContext(new Uri("http://waltdisney.com/"));
                // 
                //GET A DATATABLE FROM A GRAPH
            }
            RDFGraphSerializer.WriteRDF(
                RDFModelEnums.RDFFormats.RdfXml, waltdisney, "D:\\newfile.rdf");

        }
    }
}
