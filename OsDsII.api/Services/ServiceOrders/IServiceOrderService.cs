using OsDsII.api.Dtos.Customers;
using OsDsII.api.Dtos.ServiceOrders;

namespace OsDsII.api.Services.ServiceOrders
{
    public interface IServiceOrderService
    {
        public Task<List<Dtos.ServiceOrders.ServiceOrderDto>> GetAllAsync();
        public Task<Dtos.ServiceOrders.ServiceOrderDto> GetServiceOrderAsync(int id);
        public Task<NewServiceOrderDto> CreateServiceOrderAsync(CreateServiceOrderDto createServiceOrderDto);
        public Task FinishServiceOrderAsync(int id);
        public Task CancelServiceOrderAsync(int id);
    }
}
