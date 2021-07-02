using GetirAPI.FoodOrders.Request;
using GetirAPI.FoodOrders.Response;
using GetirAPI.Logger;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace GetirAPI.FoodOrders
{

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class OrderService : IOrderService
    {
        string token;

        public void SetToken(string token)
        {
            this.token = token;
        }

        public GetActiveFoodOrdersResponse GetActiveFoodOrders()
        {
            try
            {
                string json = JsonConvert.SerializeObject(
                    new
                    {
                        token = token
                    }
                );

                Dictionary<string, string> additionalHeaders = new Dictionary<string, string>();

                additionalHeaders.Add("token", token);


                GetActiveFoodOrdersRequest getActiveFoodOrdersRequest = new GetActiveFoodOrdersRequest("", additionalHeaders);

                GetActiveFoodOrdersResponse getActiveFoodOrdersResponse = new GetActiveFoodOrdersResponse();

                Log4Logger.Info("Trying to get active orders...");

                getActiveFoodOrdersResponse.FoodOrders = getActiveFoodOrdersRequest.MakeRequest<JsonDefinitions.Order[]>();

                if (getActiveFoodOrdersResponse != null)
                {
                    Log4Logger.Info("Successfully got active orders.");
                    return getActiveFoodOrdersResponse;
                }
                else
                {
                    Log4Logger.Info("There wasn't any active orders.");
                    return null;
                }

            }
            catch (Exception ex)
            {
                Log4Logger.Error("",ex);
                return null;
            }
        }

        public GetUAFoodOrdersResponse GetUnapprovedFoodOrders()
        {
            try
            {
                string json = JsonConvert.SerializeObject(
                    new
                    {
                        token = token 
                    }
                );

                Dictionary<string, string> additionalHeaders = new Dictionary<string, string>();

                additionalHeaders.Add("token", token);
                

                GetUAFoodOrdersRequest getUAFoodOrdersRequest = new GetUAFoodOrdersRequest("", additionalHeaders);


                Log4Logger.Info("Trying to get unapproved orders...");
                GetUAFoodOrdersResponse getUAFoodOrdersResponse = new GetUAFoodOrdersResponse();

                getUAFoodOrdersResponse.FoodOrders = getUAFoodOrdersRequest.MakeRequest<JsonDefinitions.Order[]>();

                if (getUAFoodOrdersResponse != null)
                {
                    Log4Logger.Info("Successfully got unapproved orders.");
                    return getUAFoodOrdersResponse;
                }
                else
                {
                    Log4Logger.Info("There wasn't any unapproved orders.");
                    return null;
                }

            }
            catch (Exception ex)
            {
                Log4Logger.Error("", ex);
                return null;
            }
        }

        public GetCAFoodOrdersResponse GetCanceledFoodOrders()
        {
            try
            {

                Dictionary<string, string> additionalHeaders = new Dictionary<string, string>();

                additionalHeaders.Add("token", token);

                GetCAFoodOrdersRequest getCAFoodOrdersRequest = new GetCAFoodOrdersRequest("", additionalHeaders);

                GetCAFoodOrdersResponse getCAFoodOrdersResponse = new GetCAFoodOrdersResponse();

                Log4Logger.Info("Trying to get unapproved orders...");
                getCAFoodOrdersResponse.FoodOrders = getCAFoodOrdersRequest.MakeRequest<JsonDefinitions.Order[]>();

                if (getCAFoodOrdersResponse != null)
                {
                    Log4Logger.Info("Successfully got unapproved orders.");
                    return getCAFoodOrdersResponse;
                }
                else
                {
                    Log4Logger.Info("There wasn't any unapproved orders.");
                    return null;
                }
                    

            }
            catch (Exception ex)
            {
                Log4Logger.Error("", ex);
                return null;
            }
        }
    }
}
