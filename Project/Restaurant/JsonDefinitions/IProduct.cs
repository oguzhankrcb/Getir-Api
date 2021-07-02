using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IProduct
    {
        string chainProduct { get; set; }
        Description description { get; set; }
        string id { get; set; }
        string imageURL { get; set; }
        bool isApproved { get; set; }
        Name name { get; set; }
        IList<OptionCategory> optionCategories { get; set; }
        int price { get; set; }
        string productCategory { get; set; }
        string restaurant { get; set; }
        int status { get; set; }
        int struckPrice { get; set; }
        int weight { get; set; }
        string wideImageURL { get; set; }
    }
}