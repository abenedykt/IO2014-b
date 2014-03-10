using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Substitute
{
    class GeoImport
    {
        public string GetFieldNumber(string data)
        {
            return data.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
        }
    }
}
