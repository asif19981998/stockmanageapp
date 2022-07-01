using Microsoft.Extensions.DependencyInjection;
using SMS.BLL.Abastractions.IEntity;
using SMS.BLL.Abastractions.IService;
using SMS.BLL.Services;
using SMS.DataBaseContext.dataBase;
using SMS.Repositories.Abastractions.IRepository;
using SMS.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.IoCContainer
{
    public static class IoCContainer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IJwtTokenService, JwtTokenService>();
            services.AddTransient<SMSDbContext>();
            
        }
    }
}
