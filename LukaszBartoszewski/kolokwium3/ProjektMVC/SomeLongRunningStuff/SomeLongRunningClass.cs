using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SomeLongRunningStuff.ProjektDrugi;

namespace SomeLongRunningStuff
{
    public class SomeLongRunningClass : ISomeStuff
    {
        public void MakeSomeWork(){
				 Thread.Sleep(10000);
            throw new Exception("catch me if you can");
        }
    }
}
