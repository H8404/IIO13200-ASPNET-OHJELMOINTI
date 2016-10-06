using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLJson
/// </summary>

namespace JAMK.IT
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public Person()
        {
        }


    }
    public class Politic: Person
    {
        public string Party { get; set; }
        public string Position { get; set; }
    }
}