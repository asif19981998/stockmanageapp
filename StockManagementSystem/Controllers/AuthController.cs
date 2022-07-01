
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMS.BLL.Abastractions.IService;
using SMS.Models;
using SMS.Models.AuthModels;
using SMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationIdentityUser> userManager;
        private readonly SignInManager<ApplicationIdentityUser> loginManager;
        private readonly RoleManager<ApplicationIdentityRole> roleManager;
        private readonly IJwtTokenService jwtTokenService;

        public AuthController(UserManager<ApplicationIdentityUser> userManager,
         SignInManager<ApplicationIdentityUser> loginManager,
         RoleManager<ApplicationIdentityRole> roleManager,
         IJwtTokenService jwtTokenService
            
            )
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
            this.roleManager = roleManager;
            this.jwtTokenService = jwtTokenService;
        }
        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]

        public IActionResult Register (Register model)
        {
            if (ModelState.IsValid)
            {
                ApplicationIdentityUser user = new ApplicationIdentityUser();
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.FullName = model.FullName;
                user.BirthDate = model.BirthDate;

                IdentityResult result = userManager.CreateAsync(user, model.Password).Result;

                if (result.Succeeded)
                {
                    if (!roleManager.RoleExistsAsync("NormalUser").Result)
                    {
                        ApplicationIdentityRole role = new ApplicationIdentityRole();
                        role.Name = "NormalUser";
                        role.Description = "Perform Normal operation";
                        IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                        
                        if (!roleResult.Succeeded)
                        {
                            new ResponseResult { Result = role, IsSuccess = false, Message = "Unable to set CreateRole" };
                        }
                    }

                    userManager.AddToRoleAsync(user, "NormalUser").Wait();

                    return Ok(new ResponseResult { Result = user, IsSuccess = true, Message = "Successfully User Create" });
                }

            
            }
            return Ok(new ResponseResult { Result = model, IsSuccess = false, Message = "Invalid User" });
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]

        public IActionResult Login(LoginViewModel model)
        {
            var result = loginManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false).Result;
            if (result.Succeeded)
            {
                User user = new User();
                user.Name = model.UserName;
                user.Password = model.Password;
                //Tokens token = jwtTokenService.GenerateToken(user);
                string token = jwtTokenService.GenerateToken(user);
                return  Ok(new ResponseResult { Result = token, IsSuccess = true, Message = "Successfully Login" });
            }

            return Ok(new ResponseResult { Result = model, IsSuccess = false, Message = "Login Failed !" });
        }

        [HttpPost]

        public IActionResult LogOff()
        {
            loginManager.SignOutAsync().Wait();
            return Ok(new ResponseResult { Result = null, IsSuccess = true, Message = "Successfully Log out" });
        }
    
    }
}
