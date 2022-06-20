using SMS.Model.Contracts.EntityContracts;
using SMS.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.EntityModels
{
    public class OrderList : EnityModel, IDeleteAble
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }
    }
}
