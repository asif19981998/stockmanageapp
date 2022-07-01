using System;

namespace SMS.Model.Contracts.BaseContracts
{
    public interface IConfirmable
    {
        bool IsConfirmed { get; set; }
        long? ConfirmedById { get; set; }
        DateTime? ConfirmedOn { get; set; }

        bool IsRejected { get; set; }
        long? RejectedById { get; set; }
        DateTime? RejectedOn { get; set; }
        string RejectReason { get; set; }

        //AppIdentityUser ConfirmedBy { get; set; }
        //AppIdentityUser RejectedBy { get; set; }
    }
}