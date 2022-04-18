using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using WorkerService.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace WorkerService
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

        private void CheckBackup()
        {
            //ValidParameters();
            //foreach (Backup backupModel in backupModels)
            //{
            //    if (DateTime.Now.TimeOfDay >= backupModel.StartDay && DateTime.Now.TimeOfDay <= backupModel.FinishDay)
            //    {
            //        string dir = Path.Combine(Path.Combine(directory, "backup_database"), backupModel.Name.ToLower());
            //        Directory.CreateDirectory(dir);
            //        var allFiles = Directory.GetFiles(dir);
            //        DateTime lastCreation = DateTime.MinValue;
            //        foreach (var file in allFiles)
            //        {
            //            var creationTime = new FileInfo(file).CreationTime;
            //            if (creationTime > lastCreation)
            //            {
            //                lastCreation = creationTime;
            //            }
            //        }

            //        if (lastCreation.AddMinutes(backupModel.IntervalInMinutes) <= DateTime.Now)
            //        {
            //            _logger.LogInformation($"Backup {backupModel.Name} iniciado: {DateTimeOffset.Now}");
            //            BackupMysql(backupModel, dir);
            //        }
            //    }
            //}
        }
    }
}
