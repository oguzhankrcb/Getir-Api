using GetirAPI.Utilities.Request;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

using System.Windows.Forms;

namespace GetirAPI.Utilities
{
    public abstract class RequestMaker : IHttpRequest
    {
        private static string BaseURL = "https://food-external-api-gateway.development.getirapi.com/";

        public string Endpoint { get; set; }
        public string Body { get; set; }
        public string Method { get; set; }
        public ArrayList HeaderKeys { get; set; }
        public ArrayList HeaderValues { get; set; }

        public RequestMaker()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            if (HeaderKeys == null)
            {
                HeaderKeys = new ArrayList();
                HeaderValues = new ArrayList();
            }
        }

        public static string GetRawDataFromServer(IHttpRequest request)
        {
            try
            {
                using (WebClientEx webClientEx = new WebClientEx())
                {
                    webClientEx.Timeout = 10000;
                    webClientEx.Encoding = UTF8Encoding.UTF8;

                    if (request.HeaderKeys.Count > 0)
                    {
                        for(int i = 0; i < request.HeaderKeys.Count; i++)
                        {
                            webClientEx.Headers.Add(request.HeaderKeys[i].ToString(), request.HeaderValues[i].ToString());
                        }

                    }

                    string retval = "";

                    if (string.IsNullOrEmpty(request.Body) && request.Method == "GET")
                        retval = webClientEx.DownloadString(BaseURL + request.Endpoint);
                    else
                        retval = webClientEx.UploadString(BaseURL + request.Endpoint, request.Method, request.Body);

                    return retval;
                }

            }
            catch (Exception ex)
            {
                Logger.Log4Logger.Error("", ex);
                return "";
            }
        }

        public T MakeRequest<T>() 
        {
            string response = GetRawDataFromServer(this);

            T newInstance = default(T);

            if (!string.IsNullOrEmpty(response) && response != "[]")
            {
                newInstance = JsonConvert.DeserializeObject<T>(response);
            }

            return newInstance;
        }

        public void MakeRequest()
        {
            GetRawDataFromServer(this);
        }
    }
}
