using GetirAPI.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GetirAPI.FoodOrders.Request
{
    public class GetUAFoodOrdersRequest : RequestMaker
    {
        public GetUAFoodOrdersRequest(string json, Dictionary<string, string> additionalHeaders)
        {
            Endpoint = "food-orders/periodic/unapproved";
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
