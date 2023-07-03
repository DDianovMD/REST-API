using WebAPI.Data.Models;

namespace WebAPI.Services.Contracts
{
    public interface IEmployeeService
    {
        public Task AddAsync(Employee employee);

        public Task<ICollection<Employee>> GetAllAsync();

        public Task<Employee> GetByIdAsync(string id);

        public Task UpdateAsync(Employee updatedEmployee);

        public Task DeleteAsync(Employee employee);

    }
}
