namespace WorkerService.Models
{
    public class Backup
    {
        /// <summary>
        /// identificador
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// nome descritivo
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// string de conexao que sera feito o backup
        /// </summary>
        public string ConnectionString { get; set; }
        public BackupType BackupType { get; set; }
        public FtpModel FTP { get; set; }
        public IntervalExecution Execution { get; set; }
        public Development Development { get; set; }
        /// <summary>
        /// dias para remover registro
        /// </summary>
        public int RemoveInDays { get; set; }
        /// <summary>
        /// Diretorio para salvar backup, caso vazio sera substituido pelo diretorio padrao
        /// </summary>
        public string Directory { get; set; }
    }
}
