using SMS.Models.AppConst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.Dtos
{
    public class CustomerDto
    {

        [Required]
        [StringLength(FluentApiConst.FistName40Length), MinLength(FluentApiConst.Name2Length)]
        public string Name { get; set; }

        public int CustomerType { get; set; }

        [StringLength(FluentApiConst.MobileNo15Length)]
        [RegularExpression(@"^(\d{11})$", ErrorMessage = "Mobile No Required '11' Digits Number !")]
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        
        [Required]
        [StringLength(FluentApiConst.Email50Length)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid E-Mail Address")]
        public string Email { get; set; }
        public bool IsApproved { get; set; }

    }
}
