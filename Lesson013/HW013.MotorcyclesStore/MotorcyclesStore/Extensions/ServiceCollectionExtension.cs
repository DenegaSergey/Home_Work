using Microsoft.Extensions.DependencyInjection;
using MotorcyclesStore.BLL.Services;
using MotorcyclesStore.Core.Interfaces;
using MotorcyclesStore.DAL.Repositoriyes;
using MotorcyclesStore.UI.Controllers;

namespace MotorcyclesStore.UI.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IMotoInfoRepository, MotoInfoRepository>();
            services.AddTransient<IMotoStoreService, MotoStoreService>();
            services.AddTransient<IMotoStoreController, MotoStoreController>();

            return services;
        }
    }
}
