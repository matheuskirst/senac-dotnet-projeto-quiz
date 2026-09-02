using SenacQuizApp.Enums;

namespace SenacQuizApp.Dtos.Historico
{
    // Objeto para exibir todos os quizzes de forma genérica
    public class QuizGenerico
    {
        public int Id { get; set; }
        public QuizTipo TipoId { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTimeOffset DataIniciado { get; set; }
        public bool? Concluido { get; set; }
        public DateTimeOffset? DataConcluido { get; set; }
        public TimeSpan? Tempo { get; set; }
        public int PontuacaoTotal { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string? ConcluidoDisplay => Concluido == true  ? "Sim" :
                                            Concluido == false ? "Não" :
                                                                  null;
    }
}
