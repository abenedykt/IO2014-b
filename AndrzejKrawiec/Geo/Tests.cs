﻿using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Geo
{
    public class TestsGeo
    {
        
        [Fact]
        public void Geo()
        {

            var file = Substitute.For<IGeoFileReader>();
            var repository = Substitute.For<IGeoRepository>();

            var import = new GeoImport(file, repository);

            string s = 
           @" 1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";
            
            file.GetRecord().Returns(new List<string> {s});

            
            string[] split = s.Split(' ');
            string nrDzialki = split[0];
            string x = split[1];
            string y = split[2];

            //string minX = 
            //string minY = 
            //string maxX =
            //string minY =
        }
    }
}
