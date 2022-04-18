namespace BackupDataBase.Shared.Models
{
    /// <summary>
    /// dados para subir o ultimo backup feito do banco de producao para o banco de desenvolvimento
    /// </summary>
    public class Development
    {
        /// <summary>
        /// string de conexao para a base de dados de desenvolvimento
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// intervalo para subir backup na base de dados de desenvolvimento
        /// </summary>
        public IntervalExecution Execution { get; set; }
    }
}
