using DemoDependencyInjection.Interfaces;

namespace DemoDependencyInjection.Service
{
    public class ExpressShipping : IShippingService
    {
        public decimal CalculateShippingCost(decimal weight) => weight * 3.0m; // Faster, more expensive
    }

}
