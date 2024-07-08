using Listify.Integration.Lottery;
using Listify.Repositories.LotteryCombinations;
using Microsoft.Extensions.DependencyInjection;

namespace Listify.UI
{
    public static class IntegrationConfiguration
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddTransient<ILotteryService, LotteryService>();

            return services;
        }
    }
}
