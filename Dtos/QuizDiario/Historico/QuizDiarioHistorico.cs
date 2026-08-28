using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.QuizDiario.Historico
{
    public class QuizDiarioHistorico
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public DateOnly DataExibido { get; set; }
        public DateTimeOffset DataIniciado { get; set; }
        public string Concluido { get; set; } = null!;
        public DateTimeOffset? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int TotalQuestoes { get; set; }
        public int TotalAcertos { get; set; }
        public int? PontuacaoTotal { get; set; }
    }
}
