using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IProduct
    {
        string chainProduct { get; set; }
        int count { get; set; }
        DisplayInfo displayInfo { get; set; }
        string id { get; set; }
        string imageURL { get; set; }
        Name name { get; set; }
        string note { get; set; }
        OptionCategory[] optionCategories { get; set; }
        int optionPrice { get; set; }
        int price { get; set; }
        int priceWithOption { get; set; }
        string product { get; set; }
        int totalOptionPrice { get; set; }
        int totalPrice { get; set; }
        int totalPriceWithOption { get; set; }
        string wideImageURL { get; set; }
    }
}