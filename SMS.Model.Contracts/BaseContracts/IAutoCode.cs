namespace SMS.Model.Contracts.BaseContracts
{
    public interface IAutoCode
    {
        string AutoGenNumber { get; set; }
        string AutoGenCode { get; set; }
    }
}