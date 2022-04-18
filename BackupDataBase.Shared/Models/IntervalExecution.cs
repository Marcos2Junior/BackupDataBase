using System;

namespace BackupDataBase.Shared.Models
{
    /// <summary>
    /// define intervalos de execucao
    /// </summary>
    public class IntervalExecution
    {
        /// <summary>
        /// intervalo em minutos de execucao 
        /// </summary>
        public int IntervalInMinutes { get; set; }
        /// <summary>
        /// nao executa antes desse horario no dia 
        /// </summary>
        public TimeSpan StartDay { get; set; }
        /// <summary>
        /// nao executa depois desse horario no dia
        /// </summary>
        public TimeSpan FinishDay { get; set; }
    }
}
