namespace WebAPI.Services.Contracts
{
    public interface IEmployeeService
    {
        public Task GetByAllAsync();

        public Task GetByIdAsync();

        public Task UpdateAsync();

        public Task DeleteAsync();

    }
}
