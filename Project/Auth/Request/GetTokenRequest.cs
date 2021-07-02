using GetirAPI.Utilities;
using GetirAPI.Utilities.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GetirAPI.Auth.Request
{
    public class GetTokenRequest : RequestMaker
    {
        public GetTokenRequest(string json)
        {
            Endpoint = "auth/login";
            Body = JsonConvert.SerializeObject(json);
            Method = "POST";
        }
       
    }
}
