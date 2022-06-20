﻿using SMS.Model.Contracts.EntityContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.common
{
    public class EnityModel : IDeleteAble
    {

        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeletedById { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
