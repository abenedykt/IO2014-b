using System.Threading;
using System;

namespace ProjektDrugi
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
