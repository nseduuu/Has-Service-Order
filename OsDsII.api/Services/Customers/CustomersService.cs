using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OsDsII.api.Dtos.Customers;
using OsDsII.api.Exceptions;
using OsDsII.api.Models;
using OsDsII.api.Repository.CustomersRepository;
using Xunit.Sdk;

namespace OsDsII.api.Services.Customers
{
    public sealed class CustomersService : ICustomersService
    {
        private readonly ICustomersRepository _customersRepository;
        private readonly IMapper _mapper;

        public CustomersService(ICustomersRepository customersRepository, IMapper mapper)
        {
            _customersRepository = customersRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync() 
        {
            IEnumerable<Customer> customers = await _customersRepository.GetAllAsync();
            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
            return customersDto;
        }

        public async Task CreateAsync(CreateCustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);

            var customerExists = await _customersRepository.FindUserByEmailAsync(customer.Email);
            if (customerExists != null && !customerExists.Equals(customer))
            {
                throw new ConflictException("Customer already exists");
            }

            await _customersRepository.AddCustomerAsync(customer);
        }

        public async Task DeleteAsync(int id) 
        {
            Customer customer = await _customersRepository.GetByIdAsync(id);
            if (customer is null)
            {
                throw new NotFoundException("Customer not exist");
            }
            await _customersRepository.DeleteCustomer(customer);
        }

        public async Task UpdateAsync(int id) 
        {
            Customer currentCustomer = await _customersRepository.GetByIdAsync(id);
            if (currentCustomer is null)
            {
                throw new NotFoundException("Customer not exist");
            }
            await _customersRepository.UpdateCustomerAsync(currentCustomer);
        }

    }
}