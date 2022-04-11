using System;

namespace WorkerService
{
    public class BackupModel
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public BackupType BackupType { get; set; }
        public string FTP { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IntervalInMinutes { get; set; }
        public TimeSpan StartDay { get; set; }
        public TimeSpan FinishDay { get; set; }
        public int RemoveInDays { get; set; }
    }

    public enum BackupType
    {
        MySql = 1
    }
}