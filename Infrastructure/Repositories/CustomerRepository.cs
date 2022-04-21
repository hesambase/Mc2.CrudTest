using Mc2.CrudTest.Core.Domain.Customer;
using Mc2.CrudTest.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CustomerRepository:IRepository<Customer>
    {
        Mc2Context _dbContext;
        public CustomerRepository(Mc2Context applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Customer> CreateAsync(Customer _object)
        {
            var obj = await _dbContext.Customers.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        public async Task UpdateAsync(Customer _object)
        {
            _dbContext.Customers.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Customer>> GetAllAsync()
        {
            return await _dbContext.Customers.ToListAsync();
        }
        public async Task<Customer> GetByIdAsync(int Id)
        {
            return await _dbContext.Customers.FirstOrDefaultAsync(x => x.Id == Id);
        }
        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Customers.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
    }
}
