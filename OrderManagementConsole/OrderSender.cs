using System.Threading;
using System.Threading.Tasks;

namespace OrderManagementConsole
{
    public class HttpOrderSender : IOrderSender
    {
        //private static readonly HttpClient httpClient = new HttpClient();

        public async Task<string> Send(Order order)
        {
            // var jsonOrder = JsonSerializer.Serialize<Order>(order);
            // var stringContent = new StringContent(jsonOrder, UnicodeEncoding.UTF8, "application/json");

            // //This statement calls a not existing URL. This is just an example...
            // var response = await httpClient.PostAsync("https://mymicroservice.lan/myendpoint", stringContent);

            // Emulate a 10 second operation
            await Task.Delay(10000);
            return $"\nOrder #{order.OrderId} has been sent";

        }


    }
}