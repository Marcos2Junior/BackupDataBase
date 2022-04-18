using BackupDataBase.Shared.Models;
using System.IO;

namespace WorkerService.Interfaces
{
    public interface ITypeBackupService
    {
        void Backup(Backup backupModel);
        void Restore(Backup backupModel, FileInfo fileInfo);
    }
}
