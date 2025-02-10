using AutoMapper;
using Daylon.Bakery.Stock.Communication.Requests;
using Daylon.Bakery.Stock.Communication.Responses;
using Daylon.Bakery.Stock.Domain.Entities;
using Daylon.Bakery.Stock.Domain.Repositories;
using Daylon.Bakery.Stock.Domain.Repositories.Product;

namespace Daylon.Bakery.Stock.Application.UseCases.Product.Register
{
    public class RegisterProductUseCase : IRegisterProductUseCase
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;
        private readonly IUnitOfWork _unitOfWork;


        RegisterProductUseCase(
            IMapper mapper,
            IProductRepository repository,
            IUnitOfWork unitOfWork
            )
        {
            _mapper = mapper;
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseRegisteredProductJson> Execute(RequestRegisterProductJson request)
        {
            try
            {
                //Validate the request
                Validate(request);

                //Mapper the request to an entity
                var mapper = _mapper.Map<ProductBase>(request);

                //Save
                await _repository.AddAsync(mapper);

                await _unitOfWork.CommitAsync();

                return new ResponseRegisteredProductJson()
                {
                    Id = mapper.Id,
                    Name = mapper.Name,
                    Description = mapper.Description,
                    Category = (int)mapper.Category,
                    Price = (decimal)mapper.Price,
                    Quantity = mapper.Quantity,
                    Available = mapper.Available,
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        private void Validate(RequestRegisterProductJson request)
        {
            var validator = new RegisterProductValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var error = result.Errors.Select(e => e.ErrorMessage);

                throw new System.Exception("Invalid request");
            }
        }
    }
}
