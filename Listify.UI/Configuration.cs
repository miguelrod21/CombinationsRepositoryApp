using Listify.Integration.Lottery;
using ListifyApp;
using Microsoft.Extensions.DependencyInjection;

namespace Listify.UI
{
    public class Configuration : IConfigureServices
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServicesConfiguration();
            services.AddRepositoriesConfiguration();

            services.AddTransient<MainForm>();
        }
    }
}
