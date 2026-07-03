using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Services.DiscountStrategy
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal originalPricw);
        string Description { get; }
    }
}
