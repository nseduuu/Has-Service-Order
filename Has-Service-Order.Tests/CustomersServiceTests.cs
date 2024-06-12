using AutoMapper;
using Moq;
using OsDsII.api.Dtos.Customers;
using OsDsII.api.Models;
using OsDsII.api.Repository.CustomersRepository;
using OsDsII.api.Services.Customers;

namespace CalculadoraSalario.Tests
{
    public class CustomersServiceTests
    {
        private readonly Mock<ICustomersRepository> _mockCustomersRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly CustomersService _service;
        
        public CustomersServiceTests() 
        {
            _mockCustomersRepository = new Mock<ICustomersRepository>();
            _mockMapper = new Mock<IMapper>();
            _service = new CustomersService(_mockCustomersRepository.Object, _mockMapper.Object);
        }

        [Fact]
        public async void Should_Return_A_List_Of_Customers()
        {

            List<CustomerDto> customers = new List<CustomerDto>
            {
                new CustomerDto("eduardo", "edu.noronha@gmail.com", "926455042", null),
                new CustomerDto("ana", "chata@gmail.com", "1234589", null),
                new CustomerDto("lucas", "nerd@gmail.com", "40028922", null)
            };

            // _mockCustomersRepository.Setup(repository => repository.GetAllAsync()).ReturnsAsync(customers);
            var result = await _service.GetAllAsync();
            Assert.Equal(customers , result);
        }
    }
}
