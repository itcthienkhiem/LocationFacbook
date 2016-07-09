using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client c = new ServiceReference1.Service1Client();
            //c.getAllPhotoImages("1387174581298632", "336174fabd97c0d9fa43a75d43956e84");

            c.getAllAlbums("1387174581298632|VF96nLPKg9EOglF3nSjamJCAFXU", "225005490914488");
        }
    }
}
