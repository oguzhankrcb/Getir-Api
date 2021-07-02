using GetirAPI.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GetirAPI.FoodOrders.Request
{
    public class GetCAFoodOrdersRequest : RequestMaker
    {
        public GetCAFoodOrdersRequest(string json, Dictionary<string, string> additionalHeaders)
        {
            Endpoint = "food-orders/periodic/cancelled";
            Body = JsonConvert.SerializeObject(json);
            Method = "POST";

            if (additionalHeaders.Count > 0)
            {
                foreach (KeyValuePair<string, string> keyValuePair in additionalHeaders)
                {
                    HeaderKeys.Add(keyValuePair.Key);
                    HeaderValues.Add(keyValuePair.Value);
                }
            }
        }

    }
}
