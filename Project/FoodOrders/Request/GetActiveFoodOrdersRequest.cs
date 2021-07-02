using GetirAPI.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GetirAPI.FoodOrders.Request
{
    public class GetActiveFoodOrdersRequest : RequestMaker
    {
        public GetActiveFoodOrdersRequest(string json, Dictionary<string, string> additionalHeaders)
        {
            Endpoint = "food-orders/active";
            Body = JsonConvert.SerializeObject(json);
            Method = "POST";

            if (additionalHeaders.Count > 0)
            {
                foreach(KeyValuePair<string, string> keyValuePair in additionalHeaders)
                {
                    HeaderKeys.Add(keyValuePair.Key);
                    HeaderValues.Add(keyValuePair.Value);
                }
            }
            
        }

    }
}
