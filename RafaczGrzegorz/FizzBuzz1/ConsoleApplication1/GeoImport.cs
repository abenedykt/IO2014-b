using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GeoImport
    {
        private IGeoFileReader filereader;
        private IGeoRepository repository;

        public GeoImport(IGeoFileReader filereader, IGeoRepository repository)
        {
            // TODO: Complete member initialization
            this.filereader = filereader;
            this.repository = repository;
        }
    }
}
