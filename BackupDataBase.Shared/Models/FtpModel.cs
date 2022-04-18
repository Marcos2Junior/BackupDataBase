namespace BackupDataBase.Shared.Models
{
    /// <summary>
    /// dados do servidor ftp para envio dos registros de backup
    /// </summary>
    public class FtpModel
    {
        /// <summary>
        /// endereco ftp
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// usuario ftp
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// senha ftp
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// porta ftp
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// intervalo para envio dos backup para o servidor ftp
        /// </summary>
        public IntervalExecution Execution { get; set; }
        /// <summary>
        /// quantidade maxima de arquivos que devem ser enviados, caso nao tenha limite defina valor zero
        /// sera enviado por data decrescente ex: caso valor seja 1, sera sempre enviado apenas o ultimo backup feito
        /// </summary>
        public int QtdFiles { get; set; }
    }
}
