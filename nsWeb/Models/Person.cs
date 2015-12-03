using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nsWeb.Models
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public Wallet Wallet { get; set; }
        public string Name { get; set; }
    }
}