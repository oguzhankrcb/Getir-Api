using GetirAPI.Restaurant.JsonDefinitions;
using GetirAPI.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GetirAPI.Restaurant
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class RestaurantService : RequestMaker, IRestaurantService
    {
        public void SetHeaders(ArrayList headerKeys, ArrayList headerValues)
        {
            if (headerKeys.Count > 0)
            {
                HeaderKeys = headerKeys;
                HeaderValues = headerValues;
            }
        }

        public MenuResponse GetMenu()
        {
            Endpoint = "restaurants/menu";
            Method = "GET";
            Body = "";

            return MakeRequest<MenuResponse>();
        }

    }
}
