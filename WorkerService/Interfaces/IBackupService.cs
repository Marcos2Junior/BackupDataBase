using System.Threading.Tasks;

namespace WorkerService.Interfaces
{
    public interface IBackupService
    {
        Task ExecuteAsync(string pathFileConfig);
    }
}
