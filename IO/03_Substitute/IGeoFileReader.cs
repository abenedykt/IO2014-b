﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _03_Substitute
{
    public interface IGeoFileReader
    {
        string Read(string name);
    }
}
