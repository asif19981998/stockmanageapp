﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Model.Contracts.EntityContracts
{
    public interface IDeleteAble:IEntity
    {
        bool IsDeleted { get; set; }
        long? DeletedById { get; set; }
        DateTime? DeletedOn { get; set; }
    }
}
