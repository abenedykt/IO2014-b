using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad2
{
    class GeoInport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoInport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            // TODO: Complete member initialization
            this.fileReader = fileReader;
            this.repository = repository;
        }
    }
}
