using System.Collections;
using System.Collections.Generic;

namespace GeoParser
{
    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }
}
