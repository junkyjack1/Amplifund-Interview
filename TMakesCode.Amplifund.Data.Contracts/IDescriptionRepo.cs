using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data.Contracts
{
    public interface IDescriptionRepo
    {
        Description GetCarDescriptionByPersonaId(int carId, int personaId);
    }
}
