using AutoMapper;
using OsDsII.api.Dtos.Comments;
using OsDsII.api.Dtos.Customers;
using OsDsII.api.Dtos.ServiceOrders;
using OsDsII.api.Models;
using ServiceOrderDto = OsDsII.api.Dtos.ServiceOrders.ServiceOrderDto;

namespace OsDsII.api
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<CommentDto, Comment>();
            CreateMap<ServiceOrderDto, NewServiceOrderDto>();
            CreateMap<NewServiceOrderDto, ServiceOrderDto>();
            CreateMap<NewServiceOrderDto, ServiceOrder>();
            CreateMap<ServiceOrder, NewServiceOrderDto>();
            CreateMap<CreateServiceOrderDto, ServiceOrder>();
            CreateMap<NewServiceOrderDto, ServiceOrder>();
        }
    }
}
