using System.IO;
using WorkerService.Models;

namespace WorkerService
{
    public interface ITypeBackupService
    {
        void Backup(Backup backupModel);
        void Restore(Backup backupModel, FileInfo fileInfo);
    }
}
