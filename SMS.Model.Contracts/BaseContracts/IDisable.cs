using System;

namespace SMS.Model.Contracts.BaseContracts
{
    public interface IDisable : IEntity
    {
        bool IsDisable { get; set; }
        long? DisabledById { get; set; }
        DateTime? DisableOn { get; set; }
        string DisableReason { get; set; }

        long? EnabledById { get; set; }
        DateTime? EnabledOn { get; set; }
        string EnableReason { get; set; }
        
    }
}