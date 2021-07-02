using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.Response
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFoodOrderMessageResponse
    {
        bool result { get; set; }
    }
}