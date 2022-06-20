using Base.Repositories;
using SMS.DataBaseContext.dataBase;
using SMS.Models.EntityModels;
using SMS.Repositories.Abastractions.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repositories.Repository
{
    public class CustomerRepository:BaseRepository<Customer>,ICustomerRepository
    {
        private SMSDbContext _db;
        public CustomerRepository(SMSDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
