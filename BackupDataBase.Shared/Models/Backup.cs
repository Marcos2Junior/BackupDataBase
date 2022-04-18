using System.IO;

namespace BackupDataBase.Shared.Models
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

        private string _directory;
        /// <summary>
        /// Diretorio para salvar backup, caso vazio sera substituido pelo diretorio padrao
        /// </summary>
        public string Directory
        {
            get
            {
                if (!string.IsNullOrEmpty(_directory) && !string.IsNullOrEmpty(Name))
                {
                    string name = Name;
                    foreach (var c in Path.GetInvalidFileNameChars())
                    {
                        name = name.Replace(c, '_');
                    }
                    if (name.Length == 0)
                    {
                        throw new System.Exception($"name {Name} is invalid");
                    }

                    return Path.Combine(_directory, name.ToLower());
                }

                return _directory;
            }
            set { _directory = value; }
        }

    }
}
