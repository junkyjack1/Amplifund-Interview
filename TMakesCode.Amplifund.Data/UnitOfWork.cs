using System;
using TMakesCode.Amplifund.Data.Contracts;

namespace TMakesCode.Amplifund.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICarRepo _carRepo;
        public ICarRepo CarRepo => _carRepo ?? (_carRepo = new CarRepo()

        private IDescriptionRepo _descriptionRepo;
        public IDescriptionRepo DescriptionRepo => _descriptionRepo ?? (_descriptionRepo = new DescriptionRepo());

        private IPersonaRepo _personaRepo;
        public IPersonaRepo PersonaRepo => _personaRepo ?? (_personaRepo = new PersonaRepo()); 
    }
}
