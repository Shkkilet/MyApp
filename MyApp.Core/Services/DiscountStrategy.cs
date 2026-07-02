using MyApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Services
{
    public class DiscountStrategy
    {
        public sealed class NoDiscount : IDiscountStrategy
        {
            public decimal ApplyDiscount(decimal originalPrice)
            {
                return originalPrice;
            }
            
            public string Description => "No discount";
        }
        public sealed class PercentageDiscount: IDiscountStrategy
        {
            private readonly decimal percentage;
            public PercentageDiscount(decimal percentage)
            {
                if (percentage < 0 || percentage > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.percentage = percentage;
            }

            public decimal ApplyDiscount(decimal originalPrice)
            {
                return originalPrice * (1 - percentage / 100);
            }

            public string Description => $"{percentage}% discount";

            
        }
        public sealed class FixedAmountDiscount : IDiscountStrategy
        {
            private readonly decimal amount;
            public FixedAmountDiscount(decimal amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.amount = amount;
            }
            public decimal ApplyDiscount(decimal originalPrice)
            {
                return Math.Max(0, originalPrice - amount);
            }
            public string Description => $"${amount} discount";
        }
        public static class PriceCalculator
        {
            public static decimal CalculateFinalPrice(ProductDto product, IDiscountStrategy discount)
            {
                return discount.ApplyDiscount(product.Price);
            }

            public static void PrintReceipt(ProductDto product, IDiscountStrategy discount)
            {
                Console.WriteLine($"Product: {product.Name}");
                Console.WriteLine($"Original price: {product.Price}");
                Console.WriteLine($"Discount: {discount.Description}");
                Console.WriteLine($"Final price: {CalculateFinalPrice(product, discount)}");
                Console.WriteLine();
            }
        }
    }
}
