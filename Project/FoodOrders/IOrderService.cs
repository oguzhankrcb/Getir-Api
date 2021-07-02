using GetirAPI.FoodOrders.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GetirAPI.FoodOrders
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IOrderService
    {
        void SetToken(string token);
        GetActiveFoodOrdersResponse GetActiveFoodOrders();
        GetUAFoodOrdersResponse GetUnapprovedFoodOrders();
        GetCAFoodOrdersResponse GetCanceledFoodOrders();
    }
}
