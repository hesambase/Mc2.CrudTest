using Mc2.CrudTest.Core.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface ICustomerService
    {
        Task<Customer> AddPerson(Customer person);
        Task<bool> UpdatePerson(int id, Customer person);
        Task<bool> DeletePerson(int id);
        Task<List<Customer>> GetAllPersons();
        Task<Customer> GetPerson(int id);
    }
}
