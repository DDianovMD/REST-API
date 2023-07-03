using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Models;

namespace WebAPI.Data
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
                .HasData(new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Phone = "0889337273"
                },

                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Petar",
                    LastName = "Petrov",
                    Phone = "0889123875"
                },

                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Maria",
                    LastName = "Mircheva",
                    Phone = "0882554238"
                },

                new Employee
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Kalina",
                    LastName = "Todorova",
                    Phone = "0887514544"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
