using System.Collections;
using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IRestaurantService
    {
        void SetHeaders(ArrayList headerKeys, ArrayList headerValues);
    }
}