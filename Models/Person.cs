using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWApiLab23.Models
{
    public class Person
    {

        public class RootPerson
        {
            public string name { get; set; }
            public string height { get; set; }
            public string mass { get; set; }
            public string hair_color { get; set; }
            public string skin_color { get; set; }
            public string eye_color { get; set; }
            public string birth_year { get; set; }
            public string gender { get; set; }
            public string homeworld { get; set; }
            public string[] films { get; set; }
            public string[] species { get; set; }
            public string[] vehicles { get; set; }
            public string[] starships { get; set; }
            public DateTime created { get; set; }
            public DateTime edited { get; set; }
            public string url { get; set; }
        }

    }
    public class Planet
    {

        public class RootPlanet
        {
            public string name { get; set; }
            public string rotation_period { get; set; }
            public string orbital_period { get; set; }
            public string diameter { get; set; }
            public string climate { get; set; }
            public string gravity { get; set; }
            public string terrain { get; set; }
            public string surface_water { get; set; }
            public string population { get; set; }
            public string[] residents { get; set; }
            public string[] films { get; set; }
            public DateTime created { get; set; }
            public DateTime edited { get; set; }
            public string url { get; set; }
        }

    }
}
