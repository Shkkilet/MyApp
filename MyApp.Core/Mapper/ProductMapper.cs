using MyApp.Core.DTOs;
using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Mapper
{
    public static class ProductMapper
    {
        public static ProductDto ToDto(RawProduct raw)
        {
            return new ProductDto
            {
                Id = raw.Id,
                Name = raw.Name ?? "Unknown",
                Category = raw.CategoryName ?? "Unknown",
                Price = (decimal)raw.PriceUsd,
                StockCount = raw.StockCount,
                IsAvailable = raw.IsActive && raw.StockCount > 0
            };
        }

        public static List<ProductDto> ToDtoList(List<RawProduct> raws)
        {
            return raws.Select(ToDto).ToList();
        }
    }
}
