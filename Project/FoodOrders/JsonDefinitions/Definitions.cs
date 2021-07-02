using GetirAPI.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Location : ILocation
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class DeliveryAddress : IDeliveryAddress
    {
        public string id { get; set; }
        public string address { get; set; }
        public string aptNo { get; set; }
        public string floor { get; set; }
        public string doorNo { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string description { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Client : IClient
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public string clientPhoneNumber { get; set; }
        public string clientUnmaskedPhoneNumber { get; set; }
        public string contactPhoneNumber { get; set; }
        public DeliveryAddress deliveryAddress { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Courier : ICourier
    {
        public string id { get; set; }
        public int status { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Name : IName
    {
        public string tr { get; set; }
        public string en { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class OptionCategory
    {
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Title : ITitle
    {
        public string tr { get; set; }
        public string en { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Options : IOptions
    {
        public string[] tr { get; set; }
        public string[] en { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class DisplayInfo : IDisplayInfo
    {
        public Title title { get; set; }
        public Options options { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Product : IProduct
    {
        public string id { get; set; }
        public string imageURL { get; set; }
        public string wideImageURL { get; set; }
        public int count { get; set; }
        public string product { get; set; }
        public string chainProduct { get; set; }
        public Name name { get; set; }
        public int price { get; set; }
        public int optionPrice { get; set; }
        public int priceWithOption { get; set; }
        public int totalPrice { get; set; }
        public int totalOptionPrice { get; set; }
        public int totalPriceWithOption { get; set; }
        public OptionCategory[] optionCategories { get; set; }
        public DisplayInfo displayInfo { get; set; }
        public string note { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Restaurant : IRestaurant
    {
        public string id { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class PaymentMethodText : IPaymentMethodText
    {
        public string en { get; set; }
        public string tr { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Messages : IMessages
    {
        public string tr { get; set; }
        public string en { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class CancelReason : ICancelReason
    {
        public string id { get; set; }
        public Messages messages { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Order : IOrder
    {
        public string id { get; set; }
        public int status { get; set; }
        public bool isScheduled { get; set; }
        public string confirmationId { get; set; }
        public Client client { get; set; }
        public Courier courier { get; set; }
        public Product[] products { get; set; }
        public string clientNote { get; set; }
        public int totalPrice { get; set; }
        public int totalDiscountedPrice { get; set; }
        public string checkoutDate { get; set; }
        public string scheduledDate { get; set; }
        public string verifyDate { get; set; }
        public string scheduleVerifiedDate { get; set; }
        public string prepareDate { get; set; }
        public string handoverDate { get; set; }
        public string reachDate { get; set; }
        public string deliverDate { get; set; }
        public int deliveryType { get; set; }
        public bool isEcoFriendly { get; set; }
        public bool doNotKnock { get; set; }
        public Restaurant restaurant { get; set; }
        public int paymentMethod { get; set; }
        public PaymentMethodText paymentMethodText { get; set; }
        public string cancelNote { get; set; }
        public CancelReason cancelReason { get; set; }
        public bool restaurantPanelOperation { get; set; }
    }

   
}
