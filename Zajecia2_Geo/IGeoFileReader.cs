using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajecia2_Geo
{
    public interface IGeoFileReader
    {
        string GetRecords(string fileName);
    }
}
