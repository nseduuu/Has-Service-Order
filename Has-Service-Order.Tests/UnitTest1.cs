using OsDsII.api.Services.Customers;

namespace Has_Service_Order.Tests;

public class UnitTest1
{
    [Fact]
    public void Should_Create_New_Customer()
    {
        CustomersService customersService = new CustomersService();
    }
}