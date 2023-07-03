using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Data.Models;
using WebAPI.Services.Contracts;
using WebAPI.Services.DTOs;

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

        public async Task UpdateAsync(string id, EmployeeDTO updatedEmployee)
        {
            Employee? employee = await this.context.Employees.FirstOrDefaultAsync(e => e.Id == id);

            employee!.FirstName = updatedEmployee.FirstName;
            employee.LastName = updatedEmployee.LastName;
            employee.Phone = updatedEmployee.Phone;

            this.context.Update<Employee>(employee);
            await this.context.SaveChangesAsync();
        }
    }
}
