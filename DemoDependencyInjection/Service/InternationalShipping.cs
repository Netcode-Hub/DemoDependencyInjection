using DemoDependencyInjection.Interfaces;

namespace DemoDependencyInjection.Service
{
    public class InternationalShipping : IShippingService
    {
        public decimal CalculateShippingCost(decimal weight) => weight * 5.0m; // Higher rate for international
    }

}
