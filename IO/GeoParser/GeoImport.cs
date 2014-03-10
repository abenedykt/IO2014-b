using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoParser
{
    public class GeoImport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;
        }
        internal object Parse()
        {
            throw new NotImplementedException();
        }
    }
}
