using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        public GeoImport()
        {
            // TODO: Complete member initialization
        }
        

        internal object GetNumber(string p)
        {
            return p.Split(' ').FirstOrDefault();
        }
    }
}
