using GetirAPI.Auth.Request;
using GetirAPI.Auth.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace GetirAPI
{

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Authentication : IAuthentication
    {
        private static string _appSecretKey;
        private static string _restSecretKey;

       
        public void SetSecretKeys(string appSecretKey, string restSecretKey)
        {
            _appSecretKey = appSecretKey;
            _restSecretKey = restSecretKey;
        }

        public GetTokenResponse GetToken()
        {
            try
            {
                string json = JsonConvert.SerializeObject(
                    new
                    {
                        appSecretKey = _appSecretKey,
                        restaurantSecretKey = _restSecretKey
                    }
                );

                GetTokenRequest getTokenRequest = new GetTokenRequest(json);
                
                GetTokenResponse tokenResponse = getTokenRequest.MakeRequest<GetTokenResponse>();

                if (tokenResponse != null)
                    return tokenResponse;
                else
                    return null;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
