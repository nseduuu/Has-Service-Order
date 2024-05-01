using OsDsII.api.Dtos;

namespace OsDsII.api.Services.Customers
{
    public interface ICustomersService
    {
        public Task CreateAsync(CreateCustomerDto customer);
        public Task UpdateAsync(int Id);
    }
}