using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Model;

namespace task.DataContext
{
   
        public class taskDbContext : DbContext
        {
            public taskDbContext(DbContextOptions<taskDbContext> options) : base(options)
            {

            }
            public DbSet<Address> addresses { get; set; }
            public DbSet<Person> persons { get; set; }
        public object Address { get; internal set; }
    }
    
}
