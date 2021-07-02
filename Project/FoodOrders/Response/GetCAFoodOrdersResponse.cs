using GetirAPI.FoodOrders.JsonDefinitions;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.Response
{
    [ComVisible(true)]  
    [ClassInterface(ClassInterfaceType.None)]
    public class GetCAFoodOrdersResponse : IGetCAFoodOrdersResponse
    {
        public Order[] FoodOrders { get; set; }
    }
}
