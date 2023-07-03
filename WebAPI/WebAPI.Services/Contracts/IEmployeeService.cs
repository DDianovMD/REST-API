using WebAPI.Data.Models;
using WebAPI.Services.DTOs;

namespace WebAPI.Services.Contracts
{
    public interface IEmployeeService
    {
        public Task AddAsync(Employee employee);

        public Task<ICollection<Employee>> GetAllAsync();

        public Task<Employee> GetByIdAsync(string id);

        public Task UpdateAsync(string id, EmployeeDTO updatedEmployee);

        public Task DeleteAsync(Employee employee);

    }
}
