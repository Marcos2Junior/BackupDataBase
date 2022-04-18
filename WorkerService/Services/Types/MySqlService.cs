using System;
using System.IO;
using MySql.Data.MySqlClient;
using WorkerService.Interfaces;
using Microsoft.Extensions.Logging;
using BackupDataBase.Shared.Models;

namespace WorkerService.Services.Types
{
    public class MySqlService : ITypeBackupService
    {
        private readonly ILogger<MySqlService> _logger;

        public MySqlService(ILogger<MySqlService> logger)
        {
            _logger = logger;
        }

        public void Backup(Backup backupModel)
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(backupModel.ConnectionString);
                using MySqlCommand cmd = new MySqlCommand();
                using MySqlBackup mb = new MySqlBackup(cmd);
                cmd.Connection = conn;
                conn.Open();
                mb.ExportToFile(Path.Combine(backupModel.Directory, $"{DateTime.Now:yyyyMMdd_HHmmss}.sql"));
                conn.Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
        }

        public void Restore(Backup backupModel, FileInfo fileInfo)
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(backupModel.Development.ConnectionString);
                using MySqlCommand cmd = new MySqlCommand();
                using MySqlBackup mb = new MySqlBackup(cmd);
                cmd.Connection = conn;
                conn.Open();
                mb.ImportFromFile(fileInfo.FullName);
                conn.Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
        }
    }
}
