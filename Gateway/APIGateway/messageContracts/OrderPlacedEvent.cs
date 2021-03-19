using System;

namespace APIGateway.messageContracts
{
    public class OrderPlacedEvent
    {
        public OrderPlacedEvent(Guid eventId)
        {
            EventId = new Guid();
            Timestamp = DateTime.Now;
        }

        public Guid EventId { get; private set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalCost { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Timestamp { get; private set; }
    }
}