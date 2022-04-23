using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Models.Customer;
namespace Mc2.CrudTest.Presentation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task<List<Customer>> GetAll()
        {
            return await _customerService.GetAllPersons();
        }
        [HttpGet("{id}")]
        public async Task<Customer> Get(int id)
        {
            return await _customerService.GetPerson(id);
        }
        [HttpPost]
        public async Task<Customer> AddPerson([FromBody] Person person)
        {
            return await _customerService.AddPerson(person);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeletePerson(int id)
        {
            await _customerService.DeletePerson(id);
            return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdatePerson(int id, [FromBody] Customer Object)
        {
            await _customerService.UpdatePerson(id, Object);
            return true;
        }

    }
}
