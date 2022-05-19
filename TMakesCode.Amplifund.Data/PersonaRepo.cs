using System.Collections.Generic;
using TMakesCode.Amplifund.Data.Contracts;
using TMakesCode.Amplifund.Data.Listings;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data
{
    public class PersonaRepo : IPersonaRepo
    {
        public IEnumerable<Persona> GetPersonas()
        {
            return PersonaListing.ToList();
        }
    }
}
