using Microsoft.AspNetCore.Mvc;
using SMS.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMS.BLL.Abastractions.IEntity;
using SMS.Models;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockManagementSystem.Controllers
{
    [Authorize(Roles ="NormalUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        
        public IEnumerable<Customer> Get()
        {
            //return _customerService.GetAll();

            List<Customer> customers = new List<Customer>()
            {
                new Customer{Name="A",CustomerType=1,ContactNumber="01706634346",Address="Dhanmondi",IsApproved=false},
                 new Customer{Name="B",CustomerType=1,ContactNumber="01706634346",Address="Dhanmondi",IsApproved=false},
            };

            return customers;
        }

        [HttpGet]
        [Route("getUpdatedValue")]

        //public IEnumerable<Customer> GetUpdateValue()
        //{
        //    //List<Customer> customers = new List<Customer>()
        //    //{
        //    //    new Customer(){Id=1,Name="Asif",TotalBill=12340},
        //    //    new Customer(){Id=2,Name="Makil",TotalBill=12340},
        //    //};

        //    return customers;
        //}

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        [Route("postCustomer")]
        public async Task<IActionResult> Post(Customer model)
        {
           bool isSaved = await _customerService.AddAsync(model);
            if (isSaved)
            {
                return Ok(new ResponseResult { Result=model,IsSuccess=true,Message="Successfully Saved"});
            }
            
               return Ok(new ResponseResult { Result = model, IsSuccess = false,Message="Failed To Saved" }); ;
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
