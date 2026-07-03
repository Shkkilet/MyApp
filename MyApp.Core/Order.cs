using MyApp.Core.DTOs;
using MyApp.Core.Services.DiscountStrategy;
using MyApp.Core.Services.ShippingMethod.ShippingMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core
{
    public sealed class Order
    {
        public required ProductDto Product { get; init; }
        public required IDiscountStrategy Discount { get; init; }
        public required IShippingMethod Shipping { get; init; }
        public decimal GetTotal()
        {
            decimal discountedPrice = Discount.ApplyDiscount(Product.Price);
            return discountedPrice + Shipping.Cost;
        }
    }
}