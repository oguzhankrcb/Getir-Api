using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.Restaurant.JsonDefinitions
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Name : IName
    {
        public string tr { get; set; }
        public string en { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class ClientDisplayName : IClientDisplayName
    {
        public string tr { get; set; }
        public string en { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Option : IOption
    {
        public string id { get; set; }
        public string product { get; set; }
        public string chainProduct { get; set; }
        public Name name { get; set; }
        public ClientDisplayName clientDisplayName { get; set; }
        public string optionProduct { get; set; }
        public string chainOptionProduct { get; set; }
        public IList<string> optionCategories { get; set; }
        public int type { get; set; }
        public int price { get; set; }
        public int weight { get; set; }
        public int status { get; set; }
        public string chainOption { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class OptionCategory : IOptionCategory
    {
        public string id { get; set; }
        public Name name { get; set; }
        public int minCount { get; set; }
        public int maxCount { get; set; }
        public int weight { get; set; }
        public int status { get; set; }
        public string chainOptionCategory { get; set; }
        public IList<Option> options { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Description : IDescription
    {
        public string tr { get; set; }
        public string en { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Product : IProduct
    {
        public string id { get; set; }
        public string restaurant { get; set; }
        public string productCategory { get; set; }
        public IList<OptionCategory> optionCategories { get; set; }
        public Name name { get; set; }
        public Description description { get; set; }
        public int price { get; set; }
        public int struckPrice { get; set; }
        public int weight { get; set; }
        public int status { get; set; }
        public bool isApproved { get; set; }
        public string imageURL { get; set; }
        public string wideImageURL { get; set; }
        public string chainProduct { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class ProductCategory : IProductCategory
    {
        public string id { get; set; }
        public Name name { get; set; }
        public string restaurant { get; set; }
        public IList<Product> products { get; set; }
        public bool isApproved { get; set; }
        public int weight { get; set; }
        public int status { get; set; }
        public string chainProductCategory { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class MenuResponse : IMenuResponse
    {
        public IList<ProductCategory> productCategories { get; set; }
    }

}
