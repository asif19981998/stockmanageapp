using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.Models.AuthModels;
using SMS.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataBaseContext.dataBase
{
    public class SMSDbContext: IdentityDbContext<ApplicationIdentityUser, ApplicationIdentityRole,string>
    {
        public SMSDbContext(DbContextOptions<SMSDbContext> options):base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
