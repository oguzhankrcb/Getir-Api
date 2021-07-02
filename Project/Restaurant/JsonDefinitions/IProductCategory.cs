using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IProductCategory
    {
        string chainProductCategory { get; set; }
        string id { get; set; }
        bool isApproved { get; set; }
        Name name { get; set; }
        IList<Product> products { get; set; }
        string restaurant { get; set; }
        int status { get; set; }
        int weight { get; set; }
    }
}