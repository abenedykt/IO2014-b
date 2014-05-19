using Autofack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autofack.ViewModels
{
    public class PersonViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public PersonViewModel(Person person)
        {
            this.FullName = string.Join(" ", person.FirastName, person.LastName);
            this.Age = person.Age;
        }
    }
}