using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zajecia4_EventsIRepository;


using System.Xml.Linq;namespace Zajecia4_EventsRepository
{
    public class Tests
    {
        string inputXML = "<events><event><name>PierwszyEvent</name><where>Bielsko</where></event></events>";

        [Fact]
        public void CzyDobrzeCzytaZPliku()
        {
            var fileReader = Substitute.For<IRepository>();
            fileReader.ReadXMLFromFile("data.txt").Returns(XDocument.Parse(inputXML));
            Assert.Equal(fileReader.ReadXMLFromFile("data.txt"), XDocument.Parse(inputXML));
        }

       
    }
}
