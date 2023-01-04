using Administrator_of_Products.Factories;
using Administrator_of_Products.Interfaces;
using Administrator_of_Products.Models;
using Biblioteca_Sql_Sever;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Administrator_of_Products.UI
{
    internal static class Program
    {
        private static string JsonFile = Path.Combine(Environment.CurrentDirectory,"Data","Config.json");

        [STAThread]
        static async Task Main()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile(JsonFile, false, true);
            
            IConfiguration configTree = configurationBuilder.Build();

            ServiceCollection services = new ServiceCollection();

            services.AddOptions<ConfigModel>();
            services.Configure<ConfigModel>(configTree);

            services.AddSingleton<ISqlServer, SqlServer>();
            services.AddSingleton<IGraphicInterfaceManagerFactory, GraphicInterfaceManagerFactory>();
            services.AddSingleton<IProductManagerFactory, ProductManagerFactory>();
            services.AddSingleton<IPrincipalFormFactory, PrincipalFormFactory>();
            services.AddSingleton<IOrchestrator, Orchestrator>();

            using (ServiceProvider service = services.BuildServiceProvider())
            {
                IOrchestrator orchestrator = service.GetService<IOrchestrator>();
                await orchestrator.Play();
            }
        }
    }
}