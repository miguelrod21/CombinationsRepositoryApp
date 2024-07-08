using Listify.Repositories.LotteryCombinations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listify.UI
{
    public static class RepositoryConfiguration
    {
        public static IServiceCollection AddRepositoriesConfiguration(this IServiceCollection services)
        {
            services.AddTransient<ILotteryCombinationsRepository, LotteryCombinationsRepository>();

            return services;
        }
    }
}
