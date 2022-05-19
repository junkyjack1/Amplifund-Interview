using System.Collections.Generic;
using TMakesCode.Amplifund.Biz.Reviews.Contracts;
using TMakesCode.Amplifund.Data.Contracts;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Biz.Reviews
{
    public class ReviewService : IReviewService
    {
        private IUnitOfWork UOW { get; }

        public ReviewService(IUnitOfWork uow)
        {
            UOW = uow;
        }

        public IEnumerable<Car> GetCars()
        {
            return UOW.CarRepo.GetCars();
        }

        public IEnumerable<Persona> GetPersonas()
        {
            return UOW.PersonaRepo.GetPersonas();
        }

        public Description GetCarDescriptionByPersona(int carId, int personaId)
        {
            if (carId == 0)
                throw new InvalidCarIdException();

            if (personaId == 0)
                throw new InvalidPersonaIdException();

            return UOW.DescriptionRepo.GetCarDescriptionByPersonaId(carId, personaId);
        }
    }
}
