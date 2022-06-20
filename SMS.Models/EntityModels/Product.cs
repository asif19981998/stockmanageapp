using SMS.Model.Contracts.EntityContracts;
using SMS.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.EntityModels
{
    public class Product : EnityModel, IDeleteAble
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime ManufacutureDate { get; set; }
        public DateTime ExpireDate { get; set; }
        
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<StockIn> StockIns { get; set; }



    }
}
