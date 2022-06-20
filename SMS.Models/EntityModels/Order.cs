using SMS.Model.Contracts.EntityContracts;
using SMS.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.EntityModels
{
    public class Order : EnityModel, IDeleteAble
    {
        public string Code { get; set; }

        public DateTime OrderDate { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNo { get; set; } 

        public ICollection<OrderList> OrderLists { get; set; }


    }
}
