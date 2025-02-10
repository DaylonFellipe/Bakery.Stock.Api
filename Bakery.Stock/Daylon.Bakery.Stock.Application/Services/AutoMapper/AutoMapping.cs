using AutoMapper;
using Daylon.Bakery.Stock.Communication.Requests;
using Daylon.Bakery.Stock.Domain.Entities;

namespace Daylon.Bakery.Stock.Application.Services.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<RequestRegisterProductJson, ProductBase>();
        }
    }
}
