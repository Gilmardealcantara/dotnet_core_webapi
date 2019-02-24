using Microsoft.EntityFrameworkCore;

namespace dotnet_boilerplace.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }
 
        public DbSet<Employee> Employees { get; set; }
    }
}