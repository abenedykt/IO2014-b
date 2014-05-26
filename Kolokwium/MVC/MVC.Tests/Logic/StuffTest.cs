using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Tests.Logic
{
    [TestClass]
   public class StuffTest
    {

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TryToThrowException()
        {
            ISomeStuff stuff = new SomeLongRunningStuff();
            stuff.MakeSomeWork();
        }
    }
}
