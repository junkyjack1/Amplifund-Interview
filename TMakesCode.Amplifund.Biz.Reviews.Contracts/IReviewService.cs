using System;
using System.Collections.Generic;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Biz.Reviews.Contracts
{
    public interface IReviewService
    {
        IEnumerable<Car> GetCars();
        IEnumerable<Persona> GetPersonas();
        Description GetCarDescriptionByPersona(int carId, int personaId);
    }
}
