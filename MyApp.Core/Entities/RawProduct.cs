using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Entities
{
    public class RawProduct
    {
        public int Id;
        public string? Name;
        public string? CategoryName;
        public double PriceUsd;
        public int StockCount;
        public bool IsActive;
    }
}
