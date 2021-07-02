using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IOptions
    {
        string[] en { get; set; }
        string[] tr { get; set; }
    }
}