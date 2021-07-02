using GetirAPI.FoodOrders.JsonDefinitions;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.Response
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class GetActiveFoodOrdersResponse : IGetActiveFoodOrdersResponse
    {
        public Order[] FoodOrders { get; set; }
    }
}
