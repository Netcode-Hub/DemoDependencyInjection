namespace DemoDependencyInjection.Interfaces
{
    public interface IShippingService
    {
        decimal CalculateShippingCost(decimal weight);
    }
}
