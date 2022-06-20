using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.AuthModels
{
    public class ApplicationIdentityRole:IdentityRole
    {
        public string Description { get; set; }
    }
}
