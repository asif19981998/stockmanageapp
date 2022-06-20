using Base.Contracts;
using SMS.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repositories.Abastractions.IRepository
{
    public interface ICustomerRepository:IMainRepository<Customer>
    {
    }
}
