using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IApp;

namespace IApp
{
    interface IApplication
    {
        IEnumerable<IEvents> Events();
    }
}
