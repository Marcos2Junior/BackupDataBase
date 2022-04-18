using BackupDataBase.Shared.Models;

namespace WorkerService.Interfaces
{
    public interface ITypeBackupFactory
    {
        ITypeBackupService Create(BackupType backupType);
    }
}
