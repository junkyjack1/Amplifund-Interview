using Microsoft.AspNetCore.Mvc;
using TMakesCode.Amplifund.Biz.Reviews.Contracts;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private IReviewService ReviewService { get; }

        public ReviewController(IReviewService reviewService)
        {
            ReviewService = reviewService;
        }

        [HttpGet("cars")]
        public IEnumerable<Car> GetCars()
        {
            return ReviewService.GetCars();
        }        
        
        [HttpGet("personas")]
        public IEnumerable<Persona> GetPersonas()
        {
            return ReviewService.GetPersonas();
        }

        [HttpGet("description/{carId}/{personaId}")]
        public Description GetCarDescriptionByPersonaId(int carId, int personaId)
        {
            return ReviewService.GetCarDescriptionByPersona(carId, personaId);
        }
    }
}
