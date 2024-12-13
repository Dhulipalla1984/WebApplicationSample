using Microsoft.EntityFrameworkCore;
using WebApplicationSample.Models;

namespace WebApplicationSample.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        // Define DbSets for your tables
        public DbSet<Employee> Employees { get; set; }
    }
}

