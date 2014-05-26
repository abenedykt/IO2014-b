using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projekt2
{
    public class SomeLongRunningStuff : ISomeStuff
    {
        public void MakeSomeWork() 
        {
            Thread.Sleep(10000);
        }
    }
}
