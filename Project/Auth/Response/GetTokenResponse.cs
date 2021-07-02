using GetirAPI.Utilities.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace GetirAPI.Auth.Response
{
    [ComVisible(true)]  // This is mandatory
    [ClassInterface(ClassInterfaceType.None)]
    public class GetTokenResponse : IGetTokenResponse
    {
        public string restaurantId { get; set; }
        public string token { get; set; }
    }
}
