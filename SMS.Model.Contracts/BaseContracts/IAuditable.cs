using System;

namespace SMS.Model.Contracts.BaseContracts
{
    public interface IAuditable : IEntity
    {
        long CreatedById { get; set; }
        DateTime CreatedOn { get; set; }
        long? LastModifiedById { get; set; }
        DateTime? LastModifiedOn { get; set; }
        string PublicIpAddress { get; set; }
        string LocalIpAddress { get; set; }
        string MacAddress { get; set; }
        string BrowserInfo { get; set; }
        

        //ApplicationUser CreatedBy { get; set; }
        //ApplicationUser LastModifiedBy { get; set; }
    }
}