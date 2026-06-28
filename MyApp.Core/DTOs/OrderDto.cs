using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.DTOs
{
    public sealed class OrderDto
    {
        public int OrderId { get; init; }
        public int CustomerId { get; init; }
        public string CustomerName { get; init; } = "";
        public IReadOnlyList<int> ProductIds { get; init; } = new List<int>();
        public OrderStatus Status { get; init; }
        public DateTime CreatedAt { get; init; }
    }

    public enum OrderStatus
    {
        Pending,
        Shipped,
        Cancelled
    }

}
