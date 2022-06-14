using Autofac.Extensions.DependencyInjection;
using NLog;
using NLog.Web;
using Master.API.Viagem.Rest.Api;

namespace ViagemAPI.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", true, true)
               .AddJsonFile($"appsettings.{environment}.json", true, true)
               .AddEnvironmentVariables();

            if (environment.Equals("Development", StringComparison.OrdinalIgnoreCase))
                builder.AddUserSecrets<Program>();
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


