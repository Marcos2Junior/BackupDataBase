using BackupDataBase.Shared.Models;

namespace BackupDataBase.Worker.Interfaces
{
    public interface ITypeBackupFactory
    {
        ITypeBackupService Create(BackupType backupType);
    }
}
