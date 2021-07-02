using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IOptionCategory
    {
        string chainOptionCategory { get; set; }
        string id { get; set; }
        int maxCount { get; set; }
        int minCount { get; set; }
        Name name { get; set; }
        IList<Option> options { get; set; }
        int status { get; set; }
        int weight { get; set; }
    }
}