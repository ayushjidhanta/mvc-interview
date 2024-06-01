using MVCDahboard.Models;
using Microsoft.EntityFrameworkCore;
namespace MVCDahboard.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmpId); 

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpId)
                .ValueGeneratedOnAdd(); 
        }
    }
}
