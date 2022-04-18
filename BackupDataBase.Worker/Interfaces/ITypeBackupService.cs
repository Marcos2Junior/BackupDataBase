using BackupDataBase.Shared.Models;
using System.IO;

namespace BackupDataBase.Worker.Interfaces
{
    public interface ITypeBackupService
    {
        void Backup(Backup backupModel);
        void Restore(Backup backupModel, FileInfo fileInfo);
    }
}
