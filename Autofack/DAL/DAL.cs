using Autofack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autofack.DAL
{
    public class DAL:IDAL
    {
        public Person GetPerson()
        {
            return new Person() { FirastName = "Jacek", LastName = "Placek", Age = 12 };
        }
    }
}