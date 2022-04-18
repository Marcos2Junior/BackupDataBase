using NLog;
using NLog.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace BackupDataBase.APP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IConfiguration configuration;
            var builder = new HostBuilder().ConfigureServices((context, services) =>
            {
                configuration = context.Configuration;
                services.AddScoped<FrmMain>();
                services.AddLogging(option =>
                {
                    option.AddNLog("nlog.config");
                });
            });
            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var logger = LogManager.GetCurrentClassLogger();

                try
                {
                    logger.Info("application starting");
                    Application.Run(serviceScope.ServiceProvider.GetRequiredService<FrmMain>());
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }
                finally
                {
                    logger.Info("application is closing");
                }
            }
        }
    }
}