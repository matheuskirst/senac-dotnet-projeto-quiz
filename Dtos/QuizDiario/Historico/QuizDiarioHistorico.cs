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
        public DateTime DataInicio { get; set; }
        public DateOnly DataExibido { get; set; }
        public bool FoiConcluido { get; set; }
        public DateTime? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int TotalQuestoes { get; set; }
        public int TotalAcertos { get; set; }
        public int? PontuacaoTotal { get; set; }
        public List<QuizDiarioHistoricoQuestao> Questoes { get; set; } = null!;
    }
}
