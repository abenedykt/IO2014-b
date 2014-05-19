using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using IModelBinder = System.Web.Http.ModelBinding.IModelBinder;
using ModelBindingContext = System.Web.Http.ModelBinding.ModelBindingContext;

namespace MVC.Models
{
    public class MainBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
    }
}