using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    
        public interface IRepository<T>
        {
            public Task<T> CreateAsync(T _object);
            public Task UpdateAsync(T _object);
            public Task<List<T>> GetAllAsync();
            public Task<T> GetByIdAsync(int Id);
            public Task DeleteAsync(int id);
        }
    
}
