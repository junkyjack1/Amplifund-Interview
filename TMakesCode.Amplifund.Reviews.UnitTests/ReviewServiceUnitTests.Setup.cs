using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMakesCode.Amplifund.Biz.Reviews;
using TMakesCode.Amplifund.Biz.Reviews.Contracts;

using TMakesCode.Amplifund.Data.Contracts;

namespace TMakesCode.Amplifund.Reviews.UnitTests
{
    public partial class ReviewServiceUnitTests
    {
        ServiceProvider Container { get; }

        Mock<IUnitOfWork> MoqUOW = new Mock<IUnitOfWork>();
        Mock<ICarRepo> MoqCarRepo = new Mock<ICarRepo>();
        Mock<IPersonaRepo> MoqPersonaRepo = new Mock<IPersonaRepo>();
        Mock<IDescriptionRepo> MoqDescriptionRepo = new Mock<IDescriptionRepo>();

        public ReviewServiceUnitTests()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient(container => MoqUOW.Object);
            serviceCollection.AddTransient<IReviewService, ReviewService>();

            Container = serviceCollection.BuildServiceProvider();

            InitMoqUOW();
        }

        void InitMoqUOW()
        {
            MoqUOW.Setup(uow => uow.CarRepo).Returns(MoqCarRepo.Object);
            MoqUOW.Setup(uow => uow.DescriptionRepo).Returns(MoqDescriptionRepo.Object);
            MoqUOW.Setup(uow => uow.PersonaRepo).Returns(MoqPersonaRepo.Object);
        }

        IReviewService BuildTestService()
        {
            var service = Container.GetService<IReviewService>();

            return service;
        }
    }
}
