using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IOption
    {
        string chainOption { get; set; }
        string chainOptionProduct { get; set; }
        string chainProduct { get; set; }
        ClientDisplayName clientDisplayName { get; set; }
        string id { get; set; }
        Name name { get; set; }
        IList<string> optionCategories { get; set; }
        string optionProduct { get; set; }
        int price { get; set; }
        string product { get; set; }
        int status { get; set; }
        int type { get; set; }
        int weight { get; set; }
    }
}