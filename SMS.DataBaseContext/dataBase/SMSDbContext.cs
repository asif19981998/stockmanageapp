using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.DataBaseContext.FAPIConfig.BuilderConfig;
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
        public ModelBuilderConfig ModelBuilderConfig { get; set; }
        public SMSDbContext(DbContextOptions<SMSDbContext> options):base(options)
        {
            ModelBuilderConfig = new ModelBuilderConfig();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
            ModelBuilderConfig.ApplyConfiguration(builder);

        }
    }
}
