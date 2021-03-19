using System;
using System.Collections;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using OrderPipelineContracts;

namespace Gateway
{
    public static class OrdersController
    {
        private const string OutQueue = "Orderplacednew";

        [FunctionName("PlaceOrder")]
        [return: ServiceBus(OutQueue, Connection = "ServiceBusConnection")]
        public static async Task<OrderPlacedNew> PlaceOrder(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")]
            HttpRequest req, ILogger log)
        {
            var order = System.Text.Json.JsonSerializer.Deserialize<OrderPlacedNew>(await req.ReadAsStringAsync(),
                new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            order.OrderId = Guid.NewGuid();
            order.Timestamp = DateTime.Now;

            log.LogInformation($"EventReceived for {await req.ReadAsStringAsync()}");

            // Send out via bus
            return order;
        }
    }
}