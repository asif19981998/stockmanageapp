
using System;

namespace SMS.Model.Contracts.BaseContracts
{
    public interface IDeletable : IEntity
    {
        bool IsDeleted { get; set; }
        long? DeletedById { get; set; }
        DateTime? DeletedOn { get; set; }
        //ApplicationUser DeletedBy { get; set; }
    }
}