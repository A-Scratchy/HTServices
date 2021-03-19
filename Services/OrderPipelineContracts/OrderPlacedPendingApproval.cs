using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace OrderPipelineContracts
{
    public class OrderPlacedPendingApproval
    {
        public OrderPlacedPendingApproval() => OrderId = Guid.NewGuid();

        public OrderPlacedPendingApproval(OrderPlacedNew order)
        {
            OrderId = order.OrderId;
            ShippingStreet = order.ShippingStreet;
            ShippingCity = order.ShippingCity;
            ShippingState = order.ShippingState;
            ShippingCountry = order.ShippingCountry;
            ShippingPostCode = order.ShippingPostCode;

            BillingStreet = order.BillingStreet;
            BillingCity = order.BillingCity;
            BillingState = order.BillingState;
            BillingCountry = order.BillingCountry;
            BillingPostCode = order.BillingPostCode;

            ExpectedCost = order.ExpectedCost;
            FirstName = order.FirstName;
            LastName = order.LastName;
            ContactEmail =  order.ContactEmail;
            ContactTelephone = order.ContactTelephone;
            Timestamp = order.Timestamp;
        }

        public Guid OrderId { get; set; }
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
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


        public class OrderItem
        {
            public Guid ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
    }
}