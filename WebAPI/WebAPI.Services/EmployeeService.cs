using WebAPI.Data;
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

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
