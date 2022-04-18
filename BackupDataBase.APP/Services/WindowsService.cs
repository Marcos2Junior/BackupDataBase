using BackupDataBase.Shared;
using System.Diagnostics;
using System.ServiceProcess;

namespace BackupDataBase.APP.Services
{
    public class WindowsService
    {
        public ServiceController GetService()
        {
            var sdf = ServiceController.GetServices().ToList();


            return ServiceController.GetServices().FirstOrDefault(x => x.ServiceName == Environments.ServiceName || x.DisplayName == Environments.ServiceName);
        }

        public void Install()
        {
            var proc1 = new ProcessStartInfo();
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = $"/c sc create {Environments.ServiceName} binpath={Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "workerservice", "backupdatabase.worker.exe")}";
            proc1.WindowStyle = ProcessWindowStyle.Normal;
            var p = Process.Start(proc1);
        }
    }
}
