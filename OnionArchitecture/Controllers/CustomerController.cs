using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CustomerService;

namespace OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("GetCustomer")]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerService.GetCustomer(id);
            if(result is not null) return Ok(result);
            return BadRequest();
        }

        [HttpGet("GetAllCustomer")]
        public IActionResult GetAllCustomer()
        {
            var result = _customerService.GetAllCustomer();
            if (result is not null) return Ok(result);
            return BadRequest();
        }

        [HttpPost("InsertCustomer")]
        public IActionResult InsertCustomer(Customer customer)
        {
            _customerService.InsertCustomer(customer);            
            return Ok("Data inserted");
        }

        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Update done");
        }

        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return Ok("Customer deleted");
        }

    }
}
