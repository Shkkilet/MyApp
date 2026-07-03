using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Services.ShippingMethod.ShippingMethod
{
    public class ShippingMethod
    {
        public sealed class StandardShipping : IShippingMethod
        {
            public decimal Cost => 5;
            public int EstimatedDays => 5;
            public string Name => "Standard Shipping";
        }
        public sealed class ExpressShipping : IShippingMethod
        {
            public decimal Cost => 15;
            public int EstimatedDays => 1;
            public string Name => "Express Shipping";
        }
        public sealed class FreeShipping : IShippingMethod
        {
            public decimal Cost => 0;
            public int EstimatedDays => 7;
            public string Name => "Free Shipping";
        }
    }
}
