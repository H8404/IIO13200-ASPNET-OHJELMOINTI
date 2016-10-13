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

    public class Train
    {

    }

    public class City
    {
        public Boolean passengerTraffic { get; set; }
        public string type { get; set; }
        public string stationName { get; set; }
        public string stationShortCode { get; set; }
        public string stationUICCode { get; set; }
        public string countryCode { get; set; }
       

       // "passengerTraffic":false,"type":"STATION","stationName":"Alholma","stationShortCode":"ALH","stationUICCode":308,"countryCode":"FI","longitude":22.69467280247231,"latitude":63.70825780092783
    }

}