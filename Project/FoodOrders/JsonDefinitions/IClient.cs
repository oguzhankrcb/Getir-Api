using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IClient
    {
        string clientPhoneNumber { get; set; }
        string clientUnmaskedPhoneNumber { get; set; }
        string contactPhoneNumber { get; set; }
        DeliveryAddress deliveryAddress { get; set; }
        string id { get; set; }
        Location location { get; set; }
        string name { get; set; }
    }
}