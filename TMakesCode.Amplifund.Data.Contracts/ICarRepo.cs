using System.Collections.Generic;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data.Contracts
{
    public interface ICarRepo
    {
        IEnumerable<Car> GetCars();
    }
}
