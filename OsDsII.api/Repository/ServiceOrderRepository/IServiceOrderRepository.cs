﻿using OsDsII.api.Dtos.ServiceOrders;
using OsDsII.api.Models;

namespace OsDsII.api.Repository.ServiceOrderRepository
{
    public interface IServiceOrderRepository
    {
        public Task<List<ServiceOrder>> GetAllAsync();
        public Task<ServiceOrder> GetByIdAsync(int id);
        public Task AddAsync(ServiceOrder serviceOrder);
        public Task FinishAsync(ServiceOrder serviceOrder);
        public Task CancelAsync(ServiceOrder serviceOrder);
        public Task<ServiceOrder> GetServiceOrderWithComments(int serviceOrderId);
        public Task<ServiceOrder> GetServiceOrderFromUser(int serviceOrderId);
    }
}
