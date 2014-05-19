using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Models
{
    public abstract class CustomViewPage : WebViewPage
    {
        public IDependency Dependency { get; set; }
    }
}