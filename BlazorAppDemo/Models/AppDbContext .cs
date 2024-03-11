using Microsoft.EntityFrameworkCore;

namespace BlazorAppDemo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<DemoClass> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
