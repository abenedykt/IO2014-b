using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    public class SomeLongRunningStuff : ISomeStuff
    {
        public void MakeSomeWork()
        {
            Thread.Sleep(10000);
            throw new Exception("catch me if you can");
        }
    }
}
