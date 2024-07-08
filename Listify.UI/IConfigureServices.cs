using Microsoft.Extensions.DependencyInjection;

namespace Listify.UI
{
    public interface IConfigureServices
    {
        void ConfigureServices(IServiceCollection services);
    }
}
