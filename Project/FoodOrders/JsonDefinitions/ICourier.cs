using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ICourier
    {
        string id { get; set; }
        Location location { get; set; }
        string name { get; set; }
        int status { get; set; }
    }
}