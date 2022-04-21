using Infrastructure.Repositories;
using Mc2.CrudTest.Core.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly IRepository<Customer> _customer;
        public CustomerService(IRepository<Customer> customer)
        {
            _customer = customer;
        }
        public async Task<Customer> AddPerson(Customer customer)
        {
            return await _customer.CreateAsync(customer);
        }
        public async Task<bool> UpdatePerson(int id, Customer customer)
        {
            var data = await _customer.GetByIdAsync(id);
            if (data != null)
            {
                data.Firstname = customer.Firstname;
                data.Lastname = customer.Lastname;
                data.DateOfBirth= customer.DateOfBirth;
                data.PhoneNumber = customer.BankAccountNumber;
                data.BankAccountNumber = customer.BankAccountNumber;
              
                await _customer.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
        public async Task<bool> DeletePerson(int id)
        {
            await _customer.DeleteAsync(id);
            return true;
        }
        public async Task<List<Customer>> GetAllPersons()
        {
            return await _customer.GetAllAsync();
        }
        public async Task<Customer> GetPerson(int id)
        {
            return await _customer.GetByIdAsync(id);
        }
    }
}
