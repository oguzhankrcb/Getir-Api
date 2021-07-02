using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IRestaurant
    {
        string id { get; set; }
    }
}