using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetirAPI;
using GetirAPI.Auth.Response;
using GetirAPI.Auth.Request;
using GetirAPI.FoodOrders;
using GetirAPI.FoodOrders.Response;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections;
using GetirAPI.Restaurant;
using GetirAPI.Restaurant.JsonDefinitions;
using GetirAPI.FoodOrders.JsonDefinitions;

namespace TestAPI
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Authentication authentication = new Authentication();

            authentication.SetSecretKeys("APP SECRET KEY HERE","REST SECRET KEY HERE");

            GetTokenResponse getTokenResponse = authentication.GetToken();

            if (getTokenResponse != null)
            {
                Console.WriteLine(getTokenResponse.restaurantId + " - " + getTokenResponse.token);
                Clipboard.SetText(getTokenResponse.token);
            }
            else
            {
                Console.WriteLine("Can't get token!");
            }

            ArrayList headerKeys = new ArrayList() { "token" };
            ArrayList headerValues = new ArrayList() { getTokenResponse.token };

          
            Console.Read();
        }

        private static void TestMenu(ArrayList headerKeys, ArrayList headerValues)
        {
            RestaurantService restaurantService = new RestaurantService();

            restaurantService.SetHeaders(headerKeys, headerValues);

            MenuResponse menuResponse = restaurantService.GetMenu();

            foreach (ProductCategory productCategory in menuResponse.productCategories)
            {
                foreach (GetirAPI.Restaurant.JsonDefinitions.Product product in productCategory.products)
                {
                    Console.WriteLine(product.name.tr);
                }
            }
        }

        private static void TestUnapprovedOrders(ArrayList headerKeys, ArrayList headerValues)
        {
            OrderService orderService = new OrderService();

            orderService.SetToken(headerValues[0].ToString());

            GetUAFoodOrdersResponse getUAFoodOrdersResponse = orderService.GetUnapprovedFoodOrders();

            if (getUAFoodOrdersResponse != null)
            {
                if (getUAFoodOrdersResponse.FoodOrders == null)
                    return;

                foreach (Order order in getUAFoodOrdersResponse.FoodOrders)
                {
                    OrderOperation orderOperation = new OrderOperation();

                    orderOperation.SetHeaders(headerKeys, headerValues);

                    FoodOrderMessageResponse foodOrderMessageResponse = orderOperation.MakeOperation(OrderOperation.RequestType.Verify, order);

                    if (foodOrderMessageResponse.result == true)
                    {
                        Console.WriteLine("Order : " + order.id + ", verified successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Order : " + order.id + ", can't be verified!");
                    }

                }
            }
        }

        private static void TestActiveOrders(ArrayList headerKeys, ArrayList headerValues)
        {
            OrderService orderService = new OrderService();

            orderService.SetToken(headerValues[0].ToString());

            GetActiveFoodOrdersResponse getActiveFoodOrdersResponse = orderService.GetActiveFoodOrders();

            if (getActiveFoodOrdersResponse != null)
            {
                if (getActiveFoodOrdersResponse.FoodOrders == null)
                    return;

                foreach (Order order in getActiveFoodOrdersResponse.FoodOrders)
                {
                    Console.WriteLine(order.id);
                }
            }
        }

        private static void CancelOrder(ArrayList headerKeys, ArrayList headerValues, Order order)
        {
            OrderOperation orderOperation = new OrderOperation();

            orderOperation.SetHeaders(headerKeys, headerValues);

            CancelReason[] cancelReasons = orderOperation.GetAvailableCancelReasons(order);

            foreach(CancelReason cancelReason in cancelReasons)
            {
                Console.WriteLine(cancelReason.messages.tr);
            }
        }

    }
}
