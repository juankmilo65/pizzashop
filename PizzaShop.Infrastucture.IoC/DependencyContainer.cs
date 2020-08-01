using Microsoft.Extensions.DependencyInjection;
using PizzaShop.Aplication.Interfaces;
using PizzaShop.Aplication.Services;
using PizzaShop.Domain.Interfaces;
using PizzaShop.Infrastructure.Data.Repositories;

namespace PizzaShop.Infrastructure.IoC
{
    public class DependencyContainer
    {
        /// <summary>
        /// Register services method, in this method all servicess need to be added to scope, this to be configured to dependency injection. 
        /// </summary>
        /// <param name="services">Service Collenction Interface.</param>
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<IToppingService, ToppingService>();

            //Domain.Interfaces | Data.Repositories
            services.AddScoped<IToppingRepository, ToppingRepository>();
        }
    }
}
