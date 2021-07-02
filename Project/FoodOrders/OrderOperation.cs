using GetirAPI.FoodOrders.JsonDefinitions;
using GetirAPI.FoodOrders.Response;
using GetirAPI.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GetirAPI.FoodOrders
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class OrderOperation : RequestMaker, IOrderOperation
    {
        public enum RequestType
        {
            TransferToAnotherRestaurant,
            Handover,
            VerifyScheduled,
            Verify,
            Prepare,
            Deliver,
            Cancel
        }

        public void SetHeaders(ArrayList headerKeys, ArrayList headerValues)
        {
            if (headerKeys.Count > 0)
            {
                HeaderKeys = headerKeys;
                HeaderValues = headerValues;
            }
        }

        public FoodOrderMessageResponse MakeOperation(RequestType requestType, Order order, string body = "", string method = "POST")
        {
            switch (requestType)
            {
                case RequestType.TransferToAnotherRestaurant:
                    Endpoint = "food-orders/" + order.id + "/transfer-to-another-restaurant";
                    Method = method;
                    Body = body;
                    break;
                case RequestType.Handover:
                    Endpoint = "food-orders/" + order.id + "/handover";
                    Method = method;
                    Body = body;
                    break;
                case RequestType.VerifyScheduled:
                    Endpoint = "food-orders/" + order.id + "/verify-scheduled";
                    Method = method;
                    Body = body;
                    break;
                case RequestType.Verify:
                    Endpoint = "food-orders/" + order.id + "/verify";
                    Method = method;
                    Body = body;
                    break;
                case RequestType.Prepare:
                    Endpoint = "food-orders/" + order.id + "/prepare";
                    Method = method;
                    Body = body;
                    break;
                case RequestType.Deliver:
                    Endpoint = "food-orders/" + order.id + "/deliver";
                    Method = method;
                    Body = body;
                    break;
                case RequestType.Cancel:
                    return new FoodOrderMessageResponse() { result = false };

            }

            return MakeRequest<FoodOrderMessageResponse>();
        }

        public CancelReason[] GetAvailableCancelReasons(Order order)
        {
            Endpoint = "food-orders/" + order.id + "/cancel-options";
            Method = "GET";
            Body = "";

            return MakeRequest<CancelReason[]>();
        }

        public void CancelOrder (Order order, CancelReason cancelReason)
        {
            Endpoint = "food-orders/" + order.id + "/deliver";
            Method = "POST";
            Body = JsonConvert.SerializeObject(new
            {
                cancelNote = cancelReason.messages.tr,
                cancelReasonId = cancelReason.id
            });

            MakeRequest();
        }

    }
}
