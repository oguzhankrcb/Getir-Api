using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IMenuResponse
    {
        IList<ProductCategory> productCategories { get; set; }
    }
}