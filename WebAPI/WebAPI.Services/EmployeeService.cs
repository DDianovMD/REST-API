using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Data.Models;
using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext context;

        public EmployeeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Employee employee)
        {
            await this.context.Employees.AddAsync(employee);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Employee employee)
        {
            this.context.Employees.Remove(employee);
            await this.context.SaveChangesAsync();
        }

        public async Task<ICollection<Employee>> GetAllAsync()
        {
            Employee[] employees = await this.context.Employees.ToArrayAsync();

            return employees;
        }

        public async Task<Employee> GetByIdAsync(string Id)
        {
            Employee? employee = await this.context.Employees.FirstOrDefaultAsync(e => e.Id == Id);

            return employee;
        }

        public async Task UpdateAsync(Employee updatedEmployee)
        {
            this.context.Update<Employee>(updatedEmployee);
            await this.context.SaveChangesAsync();
        }
    }
}
