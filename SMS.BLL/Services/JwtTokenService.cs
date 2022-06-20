using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SMS.BLL.Abastractions.IService;
using SMS.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Services
{
    public class JwtTokenService: IJwtTokenService
    {
        private readonly IConfiguration config;
        private readonly RoleManager<ApplicationIdentityRole> _roleManager;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        public JwtTokenService(IConfiguration config, 
            RoleManager<ApplicationIdentityRole> roleManager,
            UserManager<ApplicationIdentityUser> userManager)
        {
            this.config = config;
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        public  string GenerateToken(User model)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(config["JWT:key"]);
            var user = _userManager.FindByNameAsync(model.Name).Result;

            var roles = _userManager.GetRolesAsync(user).Result;
            Claim[] claims = new Claim[100];
            var i = 0;
           foreach(var role in roles)
            {
                claims[i] = new Claim("roles",role);
                i++;
            }



            //var tokenDescription = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(claims),

            //    Expires = DateTime.UtcNow.AddMinutes(10),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)

            //};
            JwtSecurityToken token = new JwtSecurityToken(
               //issuer: config["JWT:Issuer"],
               //audience: config["JWT:Audience"],
               claims: claims,
               expires: DateTime.UtcNow.AddMinutes(5),
               signingCredentials: new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)

               );

            return (new JwtSecurityTokenHandler()).WriteToken(token);

            //var token = tokenHandler.CreateToken(tokenDescription);
            //return new Tokens { Token = tokenHandler.WriteToken(token) };

        }
    }
}
