using DemoDependencyInjection.Interfaces;

namespace DemoDependencyInjection.Service
{
    public class StandardShipping : IShippingService
    {
        public decimal CalculateShippingCost(decimal weight) => weight * 1.5m; // Standard rate
    }

}
