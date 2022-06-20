using SMS.Model.Contracts.EntityContracts;
using SMS.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.EntityModels
{
    public class StockIn : EnityModel, IDeleteAble
    {
        public string Code { get; set; }
        public int Quantity { get; set; }
        public DateTime StockInDate { get; set; }
        public virtual long ProductId {get;set;}
        public Product Product { get; set; }


    }
}
