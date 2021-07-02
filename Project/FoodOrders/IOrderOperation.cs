using GetirAPI.FoodOrders.JsonDefinitions;
using GetirAPI.FoodOrders.Response;
using System.Collections;
using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IOrderOperation
    {
        void SetHeaders(ArrayList headerKeys, ArrayList headerValues);

        FoodOrderMessageResponse MakeOperation(OrderOperation.RequestType requestType, Order order, string body = "", string method = "POST");

        CancelReason[] GetAvailableCancelReasons(Order order);

        void CancelOrder(Order order, CancelReason cancelReason);
    }
}