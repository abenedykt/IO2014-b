using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Extras.DynamicProxy2;

namespace AspectsTest
{
    public class RedRepository : IFakeRepository
    {
        public string GetSingleEntry()
        {
            return "Red";
        }
    }
}