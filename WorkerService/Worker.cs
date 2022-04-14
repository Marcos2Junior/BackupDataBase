using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using WorkerService.Models;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly List<Backup> backupModels;
        private readonly string directory;

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            backupModels = configuration.GetSection("BackupModel").Get<List<Backup>>();
            directory = configuration["DirectoryBackup"];
            ValidParameters();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            var dsf = HttpUtility.UrlEncode("OTlMWFVxWExMV0JucUlncjA1d2NheW5IRklzS21ZdjRGaDRmbWtqR2VJSDhBUDZLR1JONTByVmtKQm5wRVhnUA==");
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
                CheckBackup();
            }
        }

        private void ValidParameters()
        {
            if (backupModels == null || backupModels.Count == 0)
            {
                throw new Exception("Backup models null or empty");
            }

            if (string.IsNullOrEmpty(directory) || !Directory.Exists(directory))
            {
                throw new Exception($"directory to backup {directory} is not found");
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
