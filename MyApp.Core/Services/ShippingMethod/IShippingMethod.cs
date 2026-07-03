using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Services.ShippingMethod.ShippingMethod
{
    public interface IShippingMethod
    {
        decimal Cost { get; }
        int EstimatedDays { get; }
        string Name { get; }
    }
}
