using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data.Listings
{
    public static class PersonaListing
    {
        public static Persona Fred { get; }
        public static Persona George { get; }
        public static Persona Lightning { get; }
        public static Persona Marge { get; }

        static PersonaListing()
        {
            Fred = new Persona
            {
                Id = 1,
                Name = "Fred Flintstone",
                Path = "Fred_Flintstone.png"
            };

            George = new Persona
            {
                Id = 2,
                Name = "George Jetson",
                Path = "George_Jetson.png"
            };

            Lightning = new Persona
            {
                Id = 3,
                Name = "Lightning McQueen",
                Path = "Lightning_McQueen.png"
            };

            Marge = new Persona
            {
                Id = 4,
                Name = "Marge Simpson",
                Path = "Marge_Simpson.png"
            };
        }

        public static List<Persona> ToList()
        {
            return new List<Persona> { Fred, George, Lightning, Marge };
        }
    }
}
