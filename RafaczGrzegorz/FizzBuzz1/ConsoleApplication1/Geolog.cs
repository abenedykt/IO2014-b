using System.Collections.Generic;
using NSubstitute;
using Xunit;

namespace ConsoleApplication1
{
   public class Geolog
    {
        [Fact]
        public void test565()
        {
            string s = @"  1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";

            var filereader = Substitute.For<IGeoFileReader>(s);
            var repository = Substitute.For<IGeoRepository>();
            var import = new GeoImport(filereader,repository);
            string [] b = s.Split(' ');
            filereader.GetRecords().Returns(new List<string>{s} );

        }
    }
}
