namespace SMS.Model.Contracts.BaseContracts
{
    public interface IOrgEntity : IEntity
    {
        long OrganizationId { get; set; }

    }
}