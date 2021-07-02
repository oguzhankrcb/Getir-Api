using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GetirAPI.FoodOrders.JsonDefinitions
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IOrder
    {
        string cancelNote { get; set; }
        CancelReason cancelReason { get; set; }
        string checkoutDate { get; set; }
        Client client { get; set; }
        string clientNote { get; set; }
        string confirmationId { get; set; }
        Courier courier { get; set; }
        string deliverDate { get; set; }
        int deliveryType { get; set; }
        bool doNotKnock { get; set; }
        string handoverDate { get; set; }
        string id { get; set; }
        bool isEcoFriendly { get; set; }
        bool isScheduled { get; set; }
        int paymentMethod { get; set; }
        PaymentMethodText paymentMethodText { get; set; }
        string prepareDate { get; set; }
        Product[] products { get; set; }
        string reachDate { get; set; }
        Restaurant restaurant { get; set; }
        bool restaurantPanelOperation { get; set; }
        string scheduledDate { get; set; }
        string scheduleVerifiedDate { get; set; }
        int status { get; set; }
        int totalDiscountedPrice { get; set; }
        int totalPrice { get; set; }
        string verifyDate { get; set; }
    }
}