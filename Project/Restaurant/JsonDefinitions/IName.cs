using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IName
    {
        string en { get; set; }
        string tr { get; set; }
    }
}