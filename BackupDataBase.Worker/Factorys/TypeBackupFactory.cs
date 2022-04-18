using BackupDataBase.Shared.Models;
using System;
using BackupDataBase.Worker.Interfaces;
using BackupDataBase.Worker.Services.Types;

namespace BackupDataBase.Worker.Factorys
{
    public class TypeBackupFactory : ITypeBackupFactory
    {
        private readonly IServiceProvider _provider;

        public TypeBackupFactory(IServiceProvider serviceProvider)
        {
            _provider = serviceProvider;
        }

        public ITypeBackupService Create(BackupType backupType)
        {
            return backupType switch
            {
                BackupType.MySql => (MySqlService)_provider.GetService(typeof(MySqlService)),
                _ => throw new Exception($"backupType {backupType} is invalid"),
            };
        }
    }
}
