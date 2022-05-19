using System.Collections.Generic;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data.Contracts
{
    public interface IPersonaRepo
    {
        IEnumerable<Persona> GetPersonas();
    }
}
