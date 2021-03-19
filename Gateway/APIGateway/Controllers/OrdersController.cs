using APIGateway.messageContracts;
using Microsoft.AspNetCore.Mvc;

namespace APIGateway.Controllers
{
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public void PlaceOrder(OrderPlacedEvent order)
        {
            
        }
    }
}