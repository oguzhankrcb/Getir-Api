using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ITitle
    {
        string en { get; set; }
        string tr { get; set; }
    }
}