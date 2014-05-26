using Kolokwium_MvcAutofacRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Kolokwium_MvcAutofacUI.DataAccessLayer
{
    public class SomeQuickRunningStuff:ISomeStuff
    {
        public void MakeSomeWork()
        {
            Thread.Sleep(2000);
        }
    }
}