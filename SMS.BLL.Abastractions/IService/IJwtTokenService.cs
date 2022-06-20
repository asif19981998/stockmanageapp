using SMS.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Abastractions.IService
{
    public interface IJwtTokenService
    {
       string GenerateToken(User model);
    }
}
