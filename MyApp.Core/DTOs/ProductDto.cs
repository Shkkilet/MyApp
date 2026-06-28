using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.DTOs
{
    public sealed class ProductDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string Category { get; init; } = "";
        public decimal Price { get; init; }
        public int StockCount { get; init; }
        public bool IsAvailable { get; init; }
    }

}
