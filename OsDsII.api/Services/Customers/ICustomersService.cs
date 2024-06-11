using OsDsII.api.Dtos.Customers;

namespace OsDsII.api.Services.Customers
{
    public interface ICustomersService
    {
        public Task<IEnumerable<CustomerDto>> GetAllAsync();
        public Task CreateAsync(CreateCustomerDto customer);
        public Task DeleteAsync(int Id);
        public Task UpdateAsync(int Id);
    }
}