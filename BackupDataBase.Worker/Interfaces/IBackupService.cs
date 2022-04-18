using System.Threading.Tasks;

namespace BackupDataBase.Worker.Interfaces
{
    public interface IBackupService
    {
        Task ExecuteAsync(string pathFileConfig);
    }
}
