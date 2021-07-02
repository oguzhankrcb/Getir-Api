using GetirAPI.FoodOrders.JsonDefinitions;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.Response
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IGetUAFoodOrdersResponse
    {
        Order[] FoodOrders { get; set; }
    }
}