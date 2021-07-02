using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GetirAPI.FoodOrders.Response
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class FoodOrderMessageResponse : IFoodOrderMessageResponse
    {
        public bool result { get; set; }
    }
}
