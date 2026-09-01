using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    // Objeto para exibir histórico de quizzes diários (em andamento/concluído)
    public class QuizDiarioHistorico
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public DateOnly DataExibido { get; set; }
        public DateTimeOffset DataIniciado { get; set; }
        public bool Concluido { get; set; }
        public DateTimeOffset? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int TotalQuestoes { get; set; }
        public int TotalAcertos { get; set; }
        public int? PontuacaoTotal { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string? ConcluidoDisplay => Concluido == true ? "Sim" :
                                    Concluido == false ? "Não" :
                                                          null;
    }
}
