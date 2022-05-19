using TMakesCode.Amplifund.Biz.Reviews;

namespace TMakesCode.Amplifund.Reviews.UnitTests
{
    public partial class ReviewServiceUnitTests
    {
        [Fact]
        public void GetCarDescriptionByPersonaId_InvalidCarId_Error()
        {
            var service = BuildTestService();

            Assert.Throws<InvalidCarIdException>(() => service.GetCarDescriptionByPersona(0, 0));
        }

        [Fact]
        public void GetCarDescriptionByPersonaId_InvalidPersonaId_Error()
        {
            var service = BuildTestService();

            Assert.Throws<InvalidPersonaIdException>(() => service.GetCarDescriptionByPersona(1, 0));
        }

        [Fact]
        public void GetCarDescriptionByPersonaId_Valid_RepoCalled()
        {
            var service = BuildTestService();

            service.GetCarDescriptionByPersona(1, 1);

            MoqDescriptionRepo.Verify(repo => repo.GetCarDescriptionByPersonaId(1, 1));
        }
    }
}