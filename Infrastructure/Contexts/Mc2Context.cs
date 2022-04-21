using Mc2.CrudTest.Core.Domain.Customer;
using Microsoft.AspNetCore.Identity;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Infrastructure.Contexts
{
    public abstract class Mc2Context : DbContext
    {
        protected Mc2Context(DbContextOptions<Mc2Context> options) : base(options)
        {
        }
      
      
        public DbSet<Customer> Customers { get; set; }

      

    }
}