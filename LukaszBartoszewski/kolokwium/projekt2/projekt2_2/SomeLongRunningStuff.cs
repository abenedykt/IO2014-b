using System;
using System.Threading;
using projekt2.Models;

namespace projekt2_2
{
    public class SomeLongRunningStuff : ISomeStuff
    {
        public void MakeSomeWork(){
				 Thread.Sleep(10000);
            throw new Exception("catch me if you can");
        }
    }
}
