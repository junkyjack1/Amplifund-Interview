namespace TMakesCode.Amplifund.Data.Contracts
{
    public interface IUnitOfWork
    {
        IPersonaRepo PersonaRepo { get; }
        IDescriptionRepo DescriptionRepo { get; }
        ICarRepo CarRepo { get; }
    }
}
