using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoParserTest
{
    class GeoImport
    {
        private IGeoRepository repository;
        private IGeoFileReader fileReader;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;
        }

        public Dictionary<string, object> Parse()
        {
            var tempList = new Dictionary<string, object>();
            
            var list = fileReader.GetRecords();
            foreach (var item in list)
            {
                
            }
            return tempList;
        }
    }
}
