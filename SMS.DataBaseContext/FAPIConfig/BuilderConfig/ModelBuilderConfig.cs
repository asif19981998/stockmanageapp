using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataBaseContext.FAPIConfig.BuilderConfig
{
    public class ModelBuilderConfig
    {

        public void ApplyConfiguration(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CustomerConfig());

        }
    }
}
