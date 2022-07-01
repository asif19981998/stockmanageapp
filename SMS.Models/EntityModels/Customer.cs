using SMS.Model.Contracts.EntityContracts;
using SMS.Models.AppConst;
using SMS.Models.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.EntityModels
{
    public class Customer : EnityModel,IDeleteAble
    {
        public string Name { get; set; }
       
        public int CustomerType { get; set; }
        
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
       
        public bool IsApproved { get; set; }
        
    }
}
