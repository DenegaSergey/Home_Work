using Microsoft.Extensions.DependencyInjection;
using SongData.BLL.Services;
using SongData.Core.Interfaces;
using SongData.DAL.Repositoriyes;

namespace SongData.UI.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ISongInfoRepository, SongInfoRepository>();
            services.AddTransient<ISongInfoService, SongInfoService>();

            return services;
        }
    }
}
