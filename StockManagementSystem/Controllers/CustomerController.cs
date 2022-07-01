using Microsoft.AspNetCore.Mvc;
using SMS.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMS.BLL.Abastractions.IEntity;
using SMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockManagementSystem.Controllers
{
    [Authorize(Roles ="NormalUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private ICustomerService _iService;

        public CustomerController(ICustomerService iService)
        {
            _iService = iService;
        }
        
        #region Get

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status302Found,Type=typeof(IEnumerable<JsonResult>))]
        public async Task<IActionResult> Get()
        {
            //return _customerService.GetAll();

            return null;
        }

        #endregion

        #region GetById
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status302Found, Type = typeof(JsonResult))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            return null;
        }
        #endregion
       
        #region Post
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(JsonResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        
        public async Task<IActionResult> Post(Customer model)
        {
           bool isSaved = await _iService.AddAsync(model);
            if (isSaved)
            {
                return Ok(new ResponseResult { Result=model,IsSuccess=true,Message="Successfully Saved"});
            }
            
               return Ok(new ResponseResult { Result = model, IsSuccess = false,Message="Failed To Saved" }); ;
        }
        #endregion
        
        #region Put

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(JsonResult))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Put(long id, Customer dto)
        {
            return  null;
        }
        #endregion
        
        #region Delete
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(JsonResult))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            return null;
        }
        #endregion
    }
}
