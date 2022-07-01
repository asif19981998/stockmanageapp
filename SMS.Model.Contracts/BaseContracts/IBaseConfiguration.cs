namespace SMS.Model.Contracts.BaseContracts
{
    public interface IBaseConfiguration
    {
        int BaseConfigId { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int ConfigurationTypeId { get; set; }
        bool IsDeactivated { get; set; }
    }
}