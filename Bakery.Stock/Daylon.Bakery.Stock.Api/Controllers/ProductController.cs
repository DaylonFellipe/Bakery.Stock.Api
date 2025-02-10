using Daylon.Bakery.Stock.Application.UseCases.Product.Register;
using Daylon.Bakery.Stock.Communication.Requests;
using Daylon.Bakery.Stock.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Daylon.Bakery.Stock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(
            [FromServices] IRegisterProductUseCase useCase,
            [FromBody] RequestRegisterProductJson request)
        {
            var result = await useCase.Execute(request);

            return Created(string.Empty, result);
        }
    }
}
