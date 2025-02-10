using Daylon.Bakery.Stock.Communication.Requests;
using Daylon.Bakery.Stock.Communication.Responses;

namespace Daylon.Bakery.Stock.Application.UseCases.Product.Register
{
    public interface IRegisterProductUseCase
    {
        public Task<ResponseRegisteredProductJson> Execute(RequestRegisterProductJson request);
    }
}
