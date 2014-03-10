using System.Collections.Generic;
using NSubstitute;
using Xunit;

namespace GeoParser
{
    public class Tests
    {
        [Fact]
        public void GetValuesTest()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            var repository = Substitute.For<IGeoRepository>();
            fileReader.GetRecords().Returns(new List<string> {Miasta.MiastoPierwsze});


            var import = new GeoImport(fileReader, repository);

            var returns = import.Parse();

        }
    }
}
