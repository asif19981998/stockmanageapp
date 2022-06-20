using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataBaseContext.dataBase
{
    public class AppDbConfiguration:DbConfiguration
    {
        public AppDbConfiguration()
        {
           SetExecutionStrategy("System.data.SqlClient",()=>new SqlAzureExecutionStrategy());
           SetDefaultConnectionFactory(new LocalDbConnectionFactory("msSqlLocalDb"));
        }
    }
}
