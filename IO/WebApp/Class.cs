using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Autofac.Extras.DynamicProxy2;

namespace WebApp
{
    public class Class:INterface
    {
        public string Connect(string connectionString)
        {
            Debug.WriteLine("connected");
            return connectionString;
        }
    }
}