
using System;
using Microsoft.Extensions.DependencyInjection;

namespace OrderManagementConsole
{
    public static class ServiceProviderBuilder
    {
        public static IServiceProvider Build()
        {
            var services = new ServiceCollection();

            services.AddTransient<IOrderSender, HttpOrderSender>();
            services.AddTransient<IOrderManager, OrderManager>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}