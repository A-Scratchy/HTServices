using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace OrderPipelineContracts
{
    public class OrderPlacedNew
    {
        public Guid OrderId { get; set; }

        public Dictionary<Guid, int> Products { get; set; } = new Dictionary<Guid, int>();
        public decimal ExpectedCost { get; set; }

        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingPostCode { get; set; }

        public string BillingStreet { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostCode { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTelephone { get; set; }
        public DateTime Timestamp { get; set; }
    }
}