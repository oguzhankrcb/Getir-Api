using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IDeliveryAddress
    {
        string address { get; set; }
        string aptNo { get; set; }
        string city { get; set; }
        string description { get; set; }
        string district { get; set; }
        string doorNo { get; set; }
        string floor { get; set; }
        string id { get; set; }
    }
}