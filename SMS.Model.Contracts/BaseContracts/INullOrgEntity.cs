namespace SMS.Model.Contracts.BaseContracts
{
    public interface INullOrgEntity : IEntity
    {
        long? OrganizationId { get; set; }

    }
}