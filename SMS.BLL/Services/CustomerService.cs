using Base.Services;
using SMS.BLL.Abastractions.IEntity;
using SMS.Models.EntityModels;
using SMS.Repositories.Abastractions.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Services
{
    public class CustomerService: BaseService<Customer>,ICustomerService
    {
        private ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
