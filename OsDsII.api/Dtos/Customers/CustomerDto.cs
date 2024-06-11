using OsDsII.api.Models;

namespace OsDsII.api.Dtos.Customers
{
    public record CustomerDto(string Name, string Email, string Phone, List<ServiceOrderDto> ListServiceOrder);

    public record ServiceOrderDto(string Description,
        double Price,
        StatusServiceOrder Status,
        DateTimeOffset OpeningDate,
        DateTimeOffset FinishDate);
}
