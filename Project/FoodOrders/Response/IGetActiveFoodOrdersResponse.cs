using GetirAPI.FoodOrders.JsonDefinitions;

namespace GetirAPI.FoodOrders.Response
{
    public interface IGetActiveFoodOrdersResponse
    {
        Order[] FoodOrders { get; set; }
    }
}