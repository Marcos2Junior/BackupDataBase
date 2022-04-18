using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using BackupDataBase.Worker.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace BackupDataBase.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IBackupService _backupService;
        private readonly string pathFileConfig;

        public Worker(ILogger<Worker> logger, IConfiguration configuration, IBackupService backupService)
        {
            _logger = logger;
            _backupService = backupService;
            pathFileConfig = configuration["PathFileConfig"];
            if (!File.Exists(pathFileConfig))
            {
                throw new FileNotFoundException($"PathFileConfig {pathFileConfig} not found");
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000, stoppingToken);

                try
                {
                    _logger.LogInformation($"backup service type {_backupService.GetType()} executing at: {DateTimeOffset.Now}");
                    await _backupService.ExecuteAsync(pathFileConfig);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message, ex);
                }
                finally
                {
                    _logger.LogInformation($"backup service finish at: {DateTimeOffset.Now}");
                }
            }
        }
    }
}
