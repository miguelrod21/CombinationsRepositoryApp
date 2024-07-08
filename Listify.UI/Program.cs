using ListifyApp;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Listify.UI
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("../logs/logger.log", rollingInterval: RollingInterval.Day)
          .CreateLogger();

            try
            {
                Log.Information("Iniciando la aplicación");

                ServiceCollection serviceCollection = new();
                Configuration configuration = new Configuration();
                configuration.ConfigureServices(serviceCollection);
                ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "La aplicación terminó inesperadamente");
            }
            finally
            {
                Log.CloseAndFlush(); 
            }
        }


    }

}