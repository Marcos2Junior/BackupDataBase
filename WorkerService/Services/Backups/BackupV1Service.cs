using System;
using BackupDataBase.Worker.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Logging;
using BackupDataBase.Shared.Models;
using System.Linq;

namespace BackupDataBase.Worker.Services.Backups
{
    public class BackupV1Service : IBackupService
    {
        private readonly ITypeBackupFactory _factoryBackup;
        private readonly ILogger<BackupV1Service> _logger;

        public BackupV1Service(ILogger<BackupV1Service> logger, ITypeBackupFactory typeBackupFactory)
        {
            _factoryBackup = typeBackupFactory;
            _logger = logger;
        }
        public async Task ExecuteAsync(string pathFileConfig)
        {
            using var fs = new FileStream(pathFileConfig, FileMode.Open, FileAccess.Read);
            using var ms = new MemoryStream();
            fs.CopyTo(ms);
            var backups = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Backup>>(ms);
            foreach (Backup backup in backups)
            {
                var files = GetFilesDirectory(backup.Directory);
                Backup(backup, files);
                Restore(backup, files);
                Delete(backup, files);
            }
        }

        private void Delete(Backup backup, IEnumerable<FileInfo> files)
        {
            if (backup.RemoveInDays > 0)
            {
                foreach (var file in files.Where(x => x.CreationTime.AddDays(backup.RemoveInDays) >= DateTime.Now))
                {
                    file.Delete();
                    _logger.LogInformation($"Removed backup type {backup.Name}; file name {file.Name}");
                }
            }
        }

        private void Restore(Backup backup, IEnumerable<FileInfo> files)
        {
            if (backup.Development != null)
            {
                if (DateTime.Now.TimeOfDay >= backup.Development.Execution.StartDay && DateTime.Now.TimeOfDay <= backup.Development.Execution.FinishDay)
                {
                    var file = Path.Combine(backup.Directory, "restore.data");
                    if (!File.Exists(file) || File.GetCreationTime(file).AddMinutes(backup.Development.Execution.IntervalInMinutes) < DateTime.Now)
                    {
                        var lastBackup = GetLastFileCreation(files);
                        if (lastBackup != null)
                        {
                            _logger.LogInformation($"Restore {backup.Name} iniciado: {DateTimeOffset.Now}");
                            _factoryBackup.Create(backup.BackupType).Restore(backup, lastBackup);
                        }
                    }
                }
            }
        }

        private void Backup(Backup backup, IEnumerable<FileInfo> files)
        {
            if (DateTime.Now.TimeOfDay >= backup.Execution.StartDay && DateTime.Now.TimeOfDay <= backup.Execution.FinishDay)
            {
                var lastBackup = GetLastFileCreation(files);

                if (lastBackup == null || lastBackup.CreationTime.AddMinutes(backup.Execution.IntervalInMinutes) <= DateTime.Now)
                {
                    _logger.LogInformation($"Backup {backup.Name} iniciado: {DateTimeOffset.Now}");
                    _factoryBackup.Create(backup.BackupType).Backup(backup);
                }
            }
        }

        private FileInfo GetLastFileCreation(IEnumerable<FileInfo> files)
        {
            return files.FirstOrDefault(x => x.CreationTime == files.Max(x => x.CreationTime));
        }

        private IEnumerable<FileInfo> GetFilesDirectory(string directory)
        {
            Directory.CreateDirectory(directory);
            return from file in Directory.GetFiles(directory, "*.sql").AsEnumerable() select new FileInfo(file);
        }
    }
}
