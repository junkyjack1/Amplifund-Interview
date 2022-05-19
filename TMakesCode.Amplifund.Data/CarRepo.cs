using System.Collections.Generic;
using System.Linq;
using TMakesCode.Amplifund.Data.Contracts;
using TMakesCode.Amplifund.Data.Listings;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data
{
    public class CarRepo : ICarRepo
    {
        public IEnumerable<Car> GetCars()
        {
            return CarListing.Query().ToList();
        }
    }
}
