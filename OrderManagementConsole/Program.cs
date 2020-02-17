using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace OrderManagementConsole
{
    class Program
    {
        private static IServiceProvider _serviceProvider = ServiceProviderBuilder.Build();

        static void Main(string[] args)
        {

            var orderManager = _serviceProvider.GetService<IOrderManager>();
            var order = CreateOrder();

            Timer.Start();
            var response = orderManager.Transmit(order);
            DisplayProcessingMessage(response);
            System.Console.WriteLine(response.Result);
            Timer.Stop();
            System.Console.WriteLine(Timer.GetElapsedTime());

        }

        private async static void DisplayProcessingMessage(Task<string> task)
        {

            System.Console.Write("Processing");
            while (!task.IsCompleted)
            {
                Console.Write(".");
                await Task.Delay(1000);
            }

        }


        private static Order CreateOrder()
        {
            return new Order
            {
                OrderId = 25,
                CustomerId = "12345",
                Date = new DateTime(),
                TotalAmount = 145,
                Items = new List<OrderItem>
                {
                    new OrderItem {
                        ItemId = "99999",
                        Quantity = 1,
                        Price = 145
                    }
                }
            };
        }
    }
}
