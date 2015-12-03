using Nancy;
using nsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nsWeb.Nancy
{
    public class PersonModule : NancyModule
    {
        public PersonModule()
        {
            Get["/"] = _ =>
            {
                var person = new Person("Andreas");  // the wallet is null
                return View["person", person];
            };
        }
    }
}