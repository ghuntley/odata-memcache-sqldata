using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odata
{

    /// <summary>
    /// This will be exposed as a list in the OData Service
    /// </summary>

    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
    }
}