using AMK.CleanArchitecture.Application.Usecases;
using Microsoft.AspNetCore.Mvc;

namespace AMK.CleanArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly PlaceOrderUseCase _placeOrderUseCase;

        public OrderController(PlaceOrderUseCase placeOrderUseCase)
        {
            _placeOrderUseCase = placeOrderUseCase;
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] OrderRequest request)
        {
            _placeOrderUseCase.Execute(request.CustomerName, request.Amount);
            return Ok("Order placed successfully.");
        }
    }

    public class OrderRequest
    {
        public required string CustomerName { get; set; }
        public decimal Amount { get; set; }
    }
}
