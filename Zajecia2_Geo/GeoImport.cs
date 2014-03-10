using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajecia2_Geo
{
    class GeoImport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            // TODO: Complete member initialization
            this.fileReader = fileReader;
            this.repository = repository;
        }

        
        
    }
}
