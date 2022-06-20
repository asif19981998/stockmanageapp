using SMS.Model.Contracts.EntityContracts;
using SMS.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.EntityModels
{
    public class Category : EnityModel, IDeleteAble
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Product> Products { get; set; }
   
    }
}
