using System.Linq;
using TMakesCode.Amplifund.Data.Contracts;
using TMakesCode.Amplifund.Data.Listings;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data
{
    public class DescriptionRepo : IDescriptionRepo
    {
        public Description GetCarDescriptionByPersonaId(int carId, int personaId)
        {
            return DescriptionListing.Query().FirstOrDefault(description =>
                description.CarId == description.CarId
                && description.PersonaId == description.PersonaId
            );
        }
    }
}
