using MyApp.Core.DTOs;
using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Mapper
{
    public static class OrderMapper
    {
        public static OrderDto ToDto(RawOrder raw)
        {
            return new OrderDto
            {
                OrderId = raw.OrderId,
                CustomerId = raw.CustomerId,
                CustomerName = raw.CustomerName ?? "Unknown",
                ProductIds = (raw.ProductIds ?? new List<int>()).AsReadOnly(),
                Status = raw.Status?.ToLower() switch
                {
                    "pending" => OrderStatus.Pending,
                    "shipped" => OrderStatus.Shipped,
                    "cancelled" => OrderStatus.Cancelled,
                    _ => throw new ArgumentException("Unknown status")
                },
                CreatedAt = raw.CreatedAt
            };
        }

        public static List<OrderDto> ToDtoList(List<RawOrder> raws)
        {
            return raws.Select(ToDto).ToList();
        }
    }
}
